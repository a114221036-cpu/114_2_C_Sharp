using System;
using System.Windows.Forms;

namespace 員工資料管理系統
{
    // 刪除員工表單：提供輸入欲刪除之員工編號的簡單介面
    // 注意：此表單僅負責輸入與回傳 DialogResult，實際刪除由主表單處理
    public partial class 刪除員工 : Form
    {
        // 暴露輸入框內容給外部（主表單會讀取此屬性來取得要刪除的 Id）
        // 使用唯讀屬性包裝 UI 控制項 txtEmployeeId 的文字，方便外部存取且避免直接操作控制項
        public string DeleteIdText => txtEmployeeId.Text;

        // 建構子：初始化元件並綁定按鈕事件
        public 刪除員工()
        {
            InitializeComponent();

            // 綁定「刪除」按鈕的事件處理器
            // 當使用者按下刪除，表單會驗證欄位並以 DialogResult.OK 回傳
            btnDelete.Click += BtnDelete_Click;

            // 綁定「離開」按鈕：直接關閉表單（不會設定 DialogResult）
            btnClose.Click += (s, e) => this.Close();
        }

        // btnDelete 的事件處理器
        // 行為：
        //  - 若輸入為空（或全為空白），顯示錯誤訊息並不關閉表單
        //  - 若輸入有值，設定 DialogResult = OK 並關閉表單（主表單收到 OK 後負責解析 ID 並執行刪除）
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // 驗證使用者是否輸入員工編號（避免空字串或只有空白）
            if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
            {
                // 提供友善提示，告知使用者需要輸入員工編號
                MessageBox.Show("請輸入員工編號。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 若輸入不為空，僅設定 DialogResult 表示使用者確定要刪除
            // 主表單收到 DialogResult.OK 後會負責將文字轉為整數並查找/刪除對應員工
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
