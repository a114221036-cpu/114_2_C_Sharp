using System;
using System.Windows.Forms;

namespace 員工資料管理系統
{
    // 新增員工表單：負責從 UI 取得輸入並建立 Employee 物件回傳給主表單
    public partial class 新增員工 : Form
    {
        // 新增完成後的結果員工物件（由主表單讀取）
        public Employee ResultEmployee { get; private set; }

        // 建構子：初始化 UI 元件並綁定按鈕事件
        public 新增員工()
        {
            InitializeComponent();

            // 綁定「新增」按鈕事件處理器（按下後驗證輸入並建立 Employee）
            btnAdd.Click += BtnAdd_Click;

            // 綁定「離開」按鈕：直接關閉表單（不回傳結果）
            btnClose.Click += (s, e) => this.Close();
        }

        // btnAdd 的事件處理器：讀取欄位、驗證、建立 Employee，並以 DialogResult.OK 回傳
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // 驗證員工編號是否可轉為整數（IdNumber 必須為整數）
            // Trim 可避免前後空白造成解析失敗
            if (!int.TryParse(txtEmployeeId.Text.Trim(), out int id))
            {
                // 若解析失敗，顯示警告並停止後續流程（不關閉表單）
                MessageBox.Show("請輸入有效的員工編號（數字）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 建立 Employee 物件，將 UI 欄位值填入對應屬性
            // 文字欄位使用 Trim() 去除前後空白，避免儲存多餘空格
            var emp = new Employee
            {
                IdNumber = id,
                Name = txtName.Text.Trim(),
                Department = txtDepartment.Text.Trim(),
                Position = txtPosition.Text.Trim()
            };

            // 將建立好的物件指派到 ResultEmployee，供主表單讀取
            ResultEmployee = emp;

            // 設定 DialogResult 為 OK，表示使用者已完成新增動作
            // 主表單會根據回傳結果取得 ResultEmployee 並進行後續處理（例如加入集合）
            this.DialogResult = DialogResult.OK;

            // 關閉表單，回到呼叫此表單的上層表單
            this.Close();
        }
    }
}
