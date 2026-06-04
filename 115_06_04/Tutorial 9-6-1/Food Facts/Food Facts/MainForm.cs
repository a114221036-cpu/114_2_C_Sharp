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
    public partial class MainForm : Form

    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            FoodItem selectedFood = null;

            // Find the selected radio button.
            if (bananaRadioButton.Checked)
            {
                selectedFood = new FoodItem("1 banana", 100, 0.4, 27);
            }
            else if (popcornRadioButton.Checked)
            {
                selectedFood = new FoodItem("3 cups of air-popped popcorn", 90, 1.5, 18);
            }
            else if (muffinRadioButton.Checked)
            {
                selectedFood = new FoodItem("1 large blueberry muffin", 385, 9, 67);
            }

            // 如果沒有選取任何食物就提示使用者並中止顯示
            if (selectedFood == null)
            {
                MessageBox.Show("請先選擇一項食物。", "未選取", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create an instance of the NutritionForm class and 傳入選取的 FoodItem。
            NutritionForm nutriForm = new NutritionForm(selectedFood);

            // Display the NutritionForm.
            nutriForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
