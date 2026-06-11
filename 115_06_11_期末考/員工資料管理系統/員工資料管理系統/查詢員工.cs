using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 員工資料管理系統
{
    // 查詢員工表單
    // 功能：
    // - 接收主表單傳入的員工集合 (List<Employee>)
    // - 使用者輸入員工編號後按下查詢，顯示該員工的詳細資料（編號/姓名/部門/職稱）
    // - 若找不到對應編號，會在輸出區顯示找不到的訊息
    public partial class 查詢員工 : Form
    {
        // 傳入的員工清單參考（不在此建立新集合，直接使用傳入的參考）
        private readonly List<Employee> employees;

        // 建構子：接收員工集合並綁定按鈕事件
        // 備註：若外部傳入 null，則以空集合取代，避免後續 NullReferenceException
        public 查詢員工(List<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees ?? new List<Employee>();

            // 綁定查詢按鈕事件：按下後執行 BtnSearch_Click
            btnSearch.Click += BtnSearch_Click;

            // 綁定離開按鈕：直接關閉表單
            btnClose.Click += (s, e) => this.Close();
        }

        // 查詢按鈕事件處理器
        // 流程：
        // 1. 清除先前輸 outputArea 內容
        // 2. 驗證使用者輸入之員工編號是否為合法整數
        // 3. 在 employees 集合中以 IdNumber 查找第一筆符合資料
        // 4. 若找不到，於輸 outputArea 顯示找不到的訊息
        // 5. 若找到，組成詳細字串並顯示於輸 outputArea （使用 StringBuilder 便於格式化）
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // 每次查詢前清空輸出區，避免殘留上一筆查詢結果造成誤導
            txtOutputArea.Clear();

            // 驗證輸入：去除前後空白後嘗試轉為整數
            // 若無法轉換，顯示警告並結束查詢流程
            if (!int.TryParse(txtEmployeeId.Text.Trim(), out int id))
            {
                MessageBox.Show("請輸入有效的員工編號（數字）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 以傳入的員工集合查找 IdNumber 相符的員工
            var emp = employees.FirstOrDefault(x => x.IdNumber == id);

            // 若找不到，顯示友善的找不到訊息（不彈跳視窗，僅在輸出區顯示）
            if (emp == null)
            {
                txtOutputArea.Text = $"找不到員工編號 {id}。";
                return;
            }

            // 使用 StringBuilder 組合輸出內容，較適合多行文字處理
            var sb = new StringBuilder();
            sb.AppendLine($"員工編號：{emp.IdNumber}");
            sb.AppendLine($"姓名：{emp.Name}");
            sb.AppendLine($"部門：{emp.Department}");
            sb.AppendLine($"職稱：{emp.Position}");

            // 將組好的字串顯示於輸出區
            txtOutputArea.Text = sb.ToString();
        }
    }
}
