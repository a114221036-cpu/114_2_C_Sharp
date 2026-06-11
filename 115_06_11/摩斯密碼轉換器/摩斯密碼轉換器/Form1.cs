using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace 摩斯密碼轉換器
{
    public partial class Form1 : Form
    {
        // struct 記錄摩斯資料
        public struct MorseEntry
        {
            public char Character;
            public string Code;

            public MorseEntry(char ch, string code)
            {
                Character = ch;
                Code = code;
            }
        }

        private List<MorseEntry> morseTable = new List<MorseEntry>();

        public Form1()
        {
            InitializeComponent();
            // 載入摩斯表（預設檔名 morse_code_table.md 放在執行目錄）
            var path = Path.Combine(Application.StartupPath, "morse_code_table.md");
            LoadMorseTable(path);
        }

        private char ParseCharToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                return '\0';

            var t = token.Trim().Trim('`').Trim().ToLowerInvariant();

            switch (t)
            {
                case "space":
                    return ' ';
                case "comma":
                    return ',';
                case "period":
                case "dot":
                    return '.';
                case "question":
                case "questionmark":
                case "?":
                    return '?';
                default:
                    // 若為單一字元，直接回傳第一個字元
                    var cleaned = token.Trim().Trim('`');
                    return cleaned.Length > 0 ? cleaned[0] : '\0';
            }
        }

        private string CleanCodeToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                return string.Empty;

            var s = token.Trim();
            // 移除 markdown inline code 標記與星號
            s = s.Trim('`').Trim('*').Trim();
            return s;
        }

        private void LoadMorseTable(string path)
        {
            morseTable.Clear();

            if (!File.Exists(path))
            {
                MessageBox.Show($"找不到摩斯檔案：{path}\n請確認檔案已放置並設定為 Copy to Output Directory。", "檔案遺失", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 使用 StreamReader 與 File.OpenText()
            using (StreamReader inputFile = File.OpenText(path))
            {
                while (!inputFile.EndOfStream)
                {
                    var line = inputFile.ReadLine();
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    line = line.Trim();

                    // 處理 markdown table 多欄位情形：每兩欄為一組 (Character | Code)
                    if (line.Contains("|"))
                    {
                        var parts = line.Split('|');
                        // parts 可能包含左右空字串，從 index 1 開始，每兩項為 pair
                        for (int i = 1; i + 1 < parts.Length; i += 2)
                        {
                            var charPart = parts[i].Trim();
                            var codePart = parts[i + 1].Trim();

                            // 跳過表頭或分隔列
                            var lowerChar = charPart.ToLowerInvariant();
                            if (string.IsNullOrEmpty(charPart) ||
                                lowerChar.Contains("character") ||
                                lowerChar.Contains("code") ||
                                lowerChar.Contains("---"))
                            {
                                continue;
                            }

                            var ch = ParseCharToken(charPart);
                            var code = CleanCodeToken(codePart);

                            if (ch != '\0' && !string.IsNullOrEmpty(code))
                            {
                                // 避免重複加入相同字元（以不區分大小寫的字元比較）
                                if (!morseTable.Any(me => char.ToUpperInvariant(me.Character) == char.ToUpperInvariant(ch)))
                                {
                                    morseTable.Add(new MorseEntry(ch, code));
                                }
                            }
                        }
                    }
                    else
                    {
                        // 解析一般格式：A .- 或 A,.- 等
                        var tokens = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        if (tokens.Length >= 2)
                        {
                            var charToken = tokens[0].Trim();
                            var codeToken = tokens[1].Trim();
                            if (!string.IsNullOrEmpty(charToken) && !string.IsNullOrEmpty(codeToken))
                            {
                                var ch = ParseCharToken(charToken);
                                var code = CleanCodeToken(codeToken);
                                if (ch != '\0' && !string.IsNullOrEmpty(code))
                                {
                                    if (!morseTable.Any(me => char.ToUpperInvariant(me.Character) == char.ToUpperInvariant(ch)))
                                    {
                                        morseTable.Add(new MorseEntry(ch, code));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // 若專案中有名為 textBox2 的控制項，使用它；否則回退到 outputTextBox
            TextBox resultBox = this.Controls.Find("textBox2", true).FirstOrDefault() as TextBox ?? outputTextBox;
            if (resultBox != null)
                resultBox.Clear();

            var input = inputTextBox.Text ?? string.Empty;
            var fullMorseParts = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                    char orig = input[i];
                // 對英文字母採不區分大小寫的比對
                char upper = char.ToUpperInvariant(orig);

                // 在 morseTable 中查找：若表的字元是字母則比較大寫後相等，否則直接比對原字元
                MorseEntry entry = morseTable.Find(me =>
                    (char.IsLetter(me.Character) && char.ToUpperInvariant(me.Character) == upper) ||
                    (!char.IsLetter(me.Character) && me.Character == orig)
                );

                if (!string.IsNullOrEmpty(entry.Code))
                {
                    fullMorseParts.Add(entry.Code);
                    if (char.IsWhiteSpace(orig))
                    {
                        listBox1.Items.Add($"(空白) => {entry.Code}");
                    }
                    else
                    {
                        listBox1.Items.Add($"{orig} => {entry.Code}");
                    }
                }
                else
                {
                    // 未定義於 morse_code_table.md，依需求忽略（不輸出、不列出）
                    continue;
                }
            }

            if (resultBox != null)
                resultBox.Text = string.Join(" ", fullMorseParts);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            // 嘗試清除 textBox2 或 outputTextBox
            TextBox resultBox = this.Controls.Find("textBox2", true).FirstOrDefault() as TextBox ?? outputTextBox;
            if (resultBox != null)
                resultBox.Clear();

            listBox1.Items.Clear();
        }
    }
}
