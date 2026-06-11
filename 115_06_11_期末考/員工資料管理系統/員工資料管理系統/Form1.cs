using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace 員工資料管理系統
{
    // 主表單：管理員工名冊的主要 UI 與流程控制
    // - 使用 List<Employee> 保存目前程式執行期間的所有員工資料
    // - 執行期間於 ListBox 顯示 IdNumber 與 Name
    // - 程式關閉時將 List<Employee> 回寫到 employees.txt（執行目錄）
    public partial class Form1 : Form
    {
        // 程式內部員工資料集合（記憶體中）
        private readonly List<Employee> employees = new List<Employee>();

        // 員工資料檔案路徑（ex: Application.StartupPath\employees.txt）
        private readonly string employeesFilePath;

        public Form1()
        {
            InitializeComponent();

            // 決定資料檔案的完整路徑（程式啟動時一次設定）
            employeesFilePath = Path.Combine(Application.StartupPath, "employees.txt");

            // 因為 Designer 檔未綁定事件，這裡在建構時動態綁定按鈕事件
            // 綁定主畫面的按鈕行為（新增、刪除、修改、查詢、離開）
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnEdit.Click += BtnEdit_Click;
            btnQuery.Click += BtnQuery_Click;
            btnClose.Click += BtnClose_Click;

            // 表單載入與關閉時的生命週期事件
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        // 表單載入：讀取檔案並刷新 ListBox 顯示
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            RefreshEmployeeListBox();
        }

        // 表單關閉：將目前員工資料儲存回檔案
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEmployees();
        }

        // 從 employees.txt 讀取員工資料並填入 employees 清單
        // 格式預期為：IdNumber|Name|Department|Position
        private void LoadEmployees()
        {
            employees.Clear();

            // 若檔案不存在則不做任何事（維持空名冊）
            if (!File.Exists(employeesFilePath)) return;

            try
            {
                foreach (var line in File.ReadAllLines(employeesFilePath))
                {
                    // 使用 Employee 類別提供的解析方法進行嚴謹解析
                    if (Employee.TryParseFromFileLine(line, out Employee emp))
                    {
                        employees.Add(emp);
                    }
                }
            }
            catch
            {
                // 為保持範例簡潔：遇到讀檔或解析錯誤時不拋出例外
                // 真實專案中建議記錄錯誤或通知使用者
            }
        }

        // 將記憶體中的 employees 集合寫回 employees.txt（覆蓋）
        private void SaveEmployees()
        {
            try
            {
                var lines = employees.Select(emp => emp.ToFileLine());
                File.WriteAllLines(employeesFilePath, lines);
            }
            catch
            {
                // 為保持簡潔：儲存失敗時不拋例外
                // 真實專案中建議處理 IO 例外並提示使用者
            }
        }

        // 重新整理主畫面上的 ListBox，用排序後的 IdNumber 顯示每位員工
        // 顯示格式：IdNumber<TAB>Name（例如：1001    王小明）
        private void RefreshEmployeeListBox()
        {
            employeeListBox.Items.Clear();
            foreach (var emp in employees.OrderBy(e => e.IdNumber))
            {
                employeeListBox.Items.Add($"{emp.IdNumber}\t{emp.Name}");
            }
        }

        // 新增員工按鈕：開啟新增員工表單，若表單回傳 DialogResult.OK 則取得結果並加入清單
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new 新增員工())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    var newEmp = form.ResultEmployee;
                    if (newEmp == null) return;

                    // 檢查 Id 是否衝突（以 IdNumber 做唯一性比對）
                    if (employees.Any(x => x.IdNumber == newEmp.IdNumber))
                    {
                        MessageBox.Show($"員工編號 {newEmp.IdNumber} 已存在。", "新增失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    employees.Add(newEmp);
                    RefreshEmployeeListBox();
                }
            }
        }

        // 刪除員工按鈭：開啟刪除員工表單，表單只回傳要刪除的 Id 字串，主表單負責驗證與移除
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (var form = new 刪除員工())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    // 以 int.TryParse 驗證輸入的 Id 是否為合法整數
                    if (!int.TryParse(form.DeleteIdText?.Trim(), out int id))
                    {
                        MessageBox.Show("請輸入有效的員工編號。", "刪除失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 以 IdNumber 查找員工，若找不到則通知使用者
                    var emp = employees.FirstOrDefault(x => x.IdNumber == id);
                    if (emp == null)
                    {
                        MessageBox.Show($"找不到員工編號 {id}。", "刪除失敗", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    employees.Remove(emp);
                    RefreshEmployeeListBox();
                }
            }
        }

        // 修改員工按鈕：以目前 employees 集合傳給修改表單，表單內處理查詢與修改
        // 修改完成後回到主表單並重新整理 ListBox 顯示
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using (var form = new 修改員工資料(employees))
            {
                form.ShowDialog(this);
                RefreshEmployeeListBox();
            }
        }

        // 查詢員工按鈕：以目前 employees 集合傳給查詢表單，由查詢表單顯示詳細資訊
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            using (var form = new 查詢員工(employees))
            {
                form.ShowDialog(this);
            }
        }

        // 離開按鈕：直接關閉主表單（觸發 FormClosing 與儲存流程）
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
