using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Facts
{
    public partial class NutritionForm : Form
    {
        private FoodItem foodItem;
        internal NutritionForm(FoodItem foodItem)
        {
            InitializeComponent();
            this.foodItem = foodItem;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void NutritionForm_Load(object sender, EventArgs e)
        {
            // 防止未提供 foodItem 導致 NullReferenceException
            if (this.foodItem == null)
            {
                MessageBox.Show("未提供食物資料。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // 使用 FoodItem 的屬性並格式化輸出（替代原本不存在的 CaloriesToString/FatToString/CarbToString）
            foodLabel.Text = foodItem.Name ?? string.Empty;
            caloriesLabel.Text = $"{foodItem.Calories} kcal";
            fatLabel.Text = $"{foodItem.Fat:F1} g";
            carbLabel.Text = $"{foodItem.Carb:F1} g";
        }
    }
}
