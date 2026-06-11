using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 員工資料管理系統
{
    // 修改員工資料表單
    // 功能概述：
    // - 接收主表單傳入的員工集合 (List<Employee>)，在此表單中可透過員工編號查詢單一員工資料，
    //   並允許使用者修改該員工的姓名、部門與職稱（修改後僅變更記憶體物件，主表單負責後續儲存）
    public partial class 修改員工資料 : Form
    {
        // 傳入並在此表單使用的員工清單（參考型別，修改後主表單可直接看到變更）
        private readonly List<Employee> employees;

        // 當前被查詢並準備修改的員工物件，若尚未查詢或查無資料則為 null
        private Employee current;

        // 建構子：接收外部傳入的員工清單（避免 null）
        // 同時在此綁定按鈕事件處理器（避免在 Designer 中修改）
        public 修改員工資料(List<Employee> employees)
        {
            InitializeComponent();

            // 若外部傳入為 null，則以空集合取代，避免後續空參考錯誤
            this.employees = employees ?? new List<Employee>();

            // 綁定「查詢」按鈕事件：查詢員工編號並填入欄位
            btnQuery.Click += BtnQuery_Click;

            // 綁定「儲存」按鈕事件：將欄位內容寫回 current（若有查到員工）
            btnSave.Click += BtnSave_Click;

            // 綁定「離開」按鈕：直接關閉表單（不做儲存動作）
            btnClose.Click += (s, e) => this.Close();
        }

        // 查詢事件處理器
        // 1. 驗證輸入是否為數字（員工編號必須能轉為 int）
        // 2. 以 IdNumber 在 employees 集合中查找匹配的員工（第一筆）
        // 3. 若找到，將該員工指定為 current 並把資料填入姓名/部門/職稱欄位供使用者修改
        // 4. 若找不到，清空欄位並提示使用者
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            // 驗證輸入是否能轉為整數；Trim 可避免前後空白造成解析失敗
            if (!int.TryParse(txtEmployeeId.Text.Trim(), out int id))
            {
                // 使用者輸入錯誤時給予友善提示並結束查詢流程
                MessageBox.Show("請輸入有效的員工編號（數字）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 在集合中尋找 IdNumber 相符的員工（若有多筆，取第一筆）
            current = employees.FirstOrDefault(x => x.IdNumber == id);

            // 若找不到則通知並清空欄位（避免殘留舊資料誤導使用者）
            if (current == null)
            {
                MessageBox.Show($"找不到員工編號 {id}。", "查無資料", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 清除可編輯欄位的內容，讓使用者重新輸入或結束操作
                txtName.Text = txtDepartment.Text = txtPosition.Text = string.Empty;
                return;
            }

            // 找到後把資料顯示在欄位上，供使用者查看與修改
            txtName.Text = current.Name;
            txtDepartment.Text = current.Department;
            txtPosition.Text = current.Position;
        }

        // 儲存事件處理器
        // 1. 檢查是否已指定 current（必須先查詢成功）
        // 2. 將使用者在欄位中修改的文字回寫到 current 的屬性
        // 3. 提示使用者已儲存（注意：此處僅修改記憶體物件，實際檔案儲存由主表單處理）
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 若尚未查詢出要修改的員工，拒絕儲存並提示
            if (current == null)
            {
                MessageBox.Show("請先查詢並選取要修改的員工。", "儲存失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 將欄位的內容（去頭尾空白）寫回員工物件，以便主表單在需要時儲存至檔案
            current.Name = txtName.Text.Trim();
            current.Department = txtDepartment.Text.Trim();
            current.Position = txtPosition.Text.Trim();

            // 顯示操作成功的訊息；如需更進一步，可改為更新主表單 UI 或自動儲存
            MessageBox.Show("已儲存修改。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
