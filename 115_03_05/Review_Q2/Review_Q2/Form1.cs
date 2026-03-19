using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Review_Q2
{
    public partial class Form1 : Form
    {
        // 費用常數
        private const decimal PRICE_OIL_CHANGE = 780m;
        private const decimal PRICE_OIL_MAINTENANCE = 540m;
        private const decimal PRICE_RADIATOR_FLUSH = 900m;
        private const decimal PRICE_TRANSMISSION_CLEAN = 2400m;
        private const decimal PRICE_INSPECTION = 450m;
        private const decimal PRICE_MUFFLER_REPLACE = 3000m;
        private const decimal PRICE_WHEEL_ALIGNMENT = 600m;
        private const decimal LABOR_RATE_PER_HOUR = 600m;
        private const decimal PARTS_TAX_RATE = 0.06m;

        public Form1()
        {
            InitializeComponent();

            // 綁定事件（以名稱在執行期找到控制項，避免設計檔中缺少欄位時編譯錯誤）
            var btnCalc = FindControl<Button>("btnCalculate");
            if (btnCalc != null) btnCalc.Click += calculateButton_Click;
            var btnClr = FindControl<Button>("btnClear");
            if (btnClr != null) btnClr.Click += clearButton_Click;
            var btnExt = FindControl<Button>("btnExit");
            if (btnExt != null) btnExt.Click += exitButton_Click;

            this.FormClosing += Form1_FormClosing;
        }

        // 以名稱尋找控制項（遞迴）
        private T FindControl<T>(string name) where T : Control
        {
            var arr = this.Controls.Find(name, true);
            if (arr != null && arr.Length > 0)
                return arr[0] as T;
            return null;
        }

        private bool IsChecked(string name)
        {
            var cb = FindControl<CheckBox>(name);
            return cb != null && cb.Checked;
        }

        private void SetChecked(string name, bool value)
        {
            var cb = FindControl<CheckBox>(name);
            if (cb != null) cb.Checked = value;
        }

        private string GetTextBoxText(string name)
        {
            var tb = FindControl<TextBox>(name);
            return tb?.Text ?? string.Empty;
        }

        private void SetTextBoxText(string name, string value)
        {
            var tb = FindControl<TextBox>(name);
            if (tb != null) tb.Text = value;
        }

        private void SetLabelText(string name, string value)
        {
            var lbl = FindControl<Label>(name);
            if (lbl != null) lbl.Text = value;
        }

        // 計算各類服務費用
        private decimal OilLubeCharges()
        {
            decimal total = 0m;
            if (IsChecked("chkOilChange")) total += PRICE_OIL_CHANGE;
            if (IsChecked("chkOilMaintenance")) total += PRICE_OIL_MAINTENANCE;
            return total;
        }

        private decimal FlushCharges()
        {
            decimal total = 0m;
            if (IsChecked("chkRadiatorFlush")) total += PRICE_RADIATOR_FLUSH;
            if (IsChecked("chkTransmissionClean")) total += PRICE_TRANSMISSION_CLEAN;
            return total;
        }

        private decimal MiscCharges()
        {
            decimal total = 0m;
            if (IsChecked("chkInspection")) total += PRICE_INSPECTION;
            if (IsChecked("chkMufflerReplace")) total += PRICE_MUFFLER_REPLACE;
            if (IsChecked("chkWheelAlignment")) total += PRICE_WHEEL_ALIGNMENT;
            return total;
        }

        private bool TryGetPartsAndHours(out decimal parts, out decimal hours)
        {
            parts = 0m;
            hours = 0m;

            var txtPartsVal = GetTextBoxText("txtParts");
            var txtHoursVal = GetTextBoxText("txtHours");

            // 解析零件
            if (!string.IsNullOrWhiteSpace(txtPartsVal))
            {
                if (!decimal.TryParse(txtPartsVal, NumberStyles.Number, CultureInfo.CurrentCulture, out parts))
                {
                    MessageBox.Show("零件費用格式錯誤，請輸入數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // 解析工時
            if (!string.IsNullOrWhiteSpace(txtHoursVal))
            {
                if (!decimal.TryParse(txtHoursVal, NumberStyles.Number, CultureInfo.CurrentCulture, out hours))
                {
                    MessageBox.Show("工時格式錯誤，請輸入數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (parts < 0 || hours < 0)
            {
                MessageBox.Show("零件費用與工時不得為負數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private decimal OtherCharges(decimal hours)
        {
            if (hours <= 0) return 0m;
            return hours * LABOR_RATE_PER_HOUR;
        }

        private decimal TaxCharges(decimal parts)
        {
            if (parts <= 0) return 0m;
            return parts * PARTS_TAX_RATE;
        }

        private decimal TotalCharges(decimal serviceAndLabor, decimal parts, decimal tax)
        {
            return serviceAndLabor + parts + tax;
        }

        // 事件處理：計算總額
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!TryGetPartsAndHours(out decimal parts, out decimal hours))
                return;

            decimal oilLube = OilLubeCharges();
            decimal flush = FlushCharges();
            decimal misc = MiscCharges();

            decimal servicesTotal = oilLube + flush + misc;
            decimal labor = OtherCharges(hours);
            decimal serviceAndLabor = servicesTotal + labor;
            decimal tax = TaxCharges(parts);
            decimal total = TotalCharges(serviceAndLabor, parts, tax);

            // 顯示
            SetLabelText("lblServiceAndLaborValue", FormatCurrency(serviceAndLabor));
            SetLabelText("lblPartsCostValue", FormatCurrency(parts));
            SetLabelText("lblTaxValue", FormatCurrency(tax));
            SetLabelText("lblTotalValue", FormatCurrency(total));
        }

        // 清除按鈕
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 個別清除方法
        private void ClearOilLube()
        {
            SetChecked("chkOilChange", false);
            SetChecked("chkOilMaintenance", false);
        }

        private void ClearFlushes()
        {
            SetChecked("chkRadiatorFlush", false);
            SetChecked("chkTransmissionClean", false);
        }

        private void ClearMisc()
        {
            SetChecked("chkInspection", false);
            SetChecked("chkMufflerReplace", false);
            SetChecked("chkWheelAlignment", false);
        }

        private void ClearOther()
        {
            SetTextBoxText("txtParts", string.Empty);
            SetTextBoxText("txtHours", string.Empty);
        }

        private void ClearFees()
        {
            SetLabelText("lblServiceAndLaborValue", string.Empty);
            SetLabelText("lblPartsCostValue", string.Empty);
            SetLabelText("lblTaxValue", string.Empty);
            SetLabelText("lblTotalValue", string.Empty);
        }

        // 報表儲存
        private void SaveServiceDetailsToFile()
        {
            if (!TryGetPartsAndHours(out decimal parts, out decimal hours))
                return;

            decimal oilLube = OilLubeCharges();
            decimal flush = FlushCharges();
            decimal misc = MiscCharges();
            decimal servicesTotal = oilLube + flush + misc;
            decimal labor = OtherCharges(hours);
            decimal serviceAndLabor = servicesTotal + labor;
            decimal tax = TaxCharges(parts);
            decimal total = TotalCharges(serviceAndLabor, parts, tax);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text File|*.txt|All Files|*.*";
                sfd.DefaultExt = "txt";
                sfd.AddExtension = true;
                sfd.FileName = "ServiceReport_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(false)))
                    {
                        sw.WriteLine("汽車維修服務明細報表");
                        sw.WriteLine("產生時間: {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        sw.WriteLine(new string('-', 60));

                        void WriteItem(string name, decimal amount)
                        {
                            sw.WriteLine($"{name.PadRight(30)} {FormatCurrency(amount).PadLeft(15)}");
                        }

                        if (oilLube > 0) WriteItem("機油與潤滑 (小計)", oilLube);
                        if (IsChecked("chkOilChange")) WriteItem(" - 更換機油", PRICE_OIL_CHANGE);
                        if (IsChecked("chkOilMaintenance")) WriteItem(" - 潤滑保養", PRICE_OIL_MAINTENANCE);

                        if (flush > 0) WriteItem("清洗服務 (小計)", flush);
                        if (IsChecked("chkRadiatorFlush")) WriteItem(" - 水箱清洗", PRICE_RADIATOR_FLUSH);
                        if (IsChecked("chkTransmissionClean")) WriteItem(" - 變速箱清洗", PRICE_TRANSMISSION_CLEAN);

                        if (misc > 0) WriteItem("其他服務 (小計)", misc);
                        if (IsChecked("chkInspection")) WriteItem(" - 檢驗", PRICE_INSPECTION);
                        if (IsChecked("chkMufflerReplace")) WriteItem(" - 更換消音器", PRICE_MUFFLER_REPLACE);
                        if (IsChecked("chkWheelAlignment")) WriteItem(" - 輪胎定位", PRICE_WHEEL_ALIGNMENT);

                        sw.WriteLine(new string('-', 60));
                        sw.WriteLine($"服務與工資 (含工時 {hours} 小時):{FormatCurrency(serviceAndLabor).PadLeft(20)}");
                        sw.WriteLine($"零件: {FormatCurrency(parts).PadLeft(36)}");
                        sw.WriteLine($"稅金 (零件 6%): {FormatCurrency(tax).PadLeft(29)}");
                        sw.WriteLine(new string('-', 60));
                        sw.WriteLine($"總費用: {FormatCurrency(total).PadLeft(40)}");

                        sw.Flush();
                    }

                    MessageBox.Show("報表已儲存。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"儲存檔案失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 在關閉前詢問是否儲存明細
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("離開前是否要儲存維修明細？", "離開確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }

            if (res == DialogResult.Yes)
            {
                SaveServiceDetailsToFile();
            }
        }

        private static string FormatCurrency(decimal amount)
        {
            // 無小數，帶千分號，前綴 NT$
            return "NT$" + Math.Truncate(amount).ToString("N0", CultureInfo.CurrentCulture);
        }
    }
}
