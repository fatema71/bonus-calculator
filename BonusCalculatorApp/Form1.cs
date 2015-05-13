using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusCalculatorApp
{
    public partial class BonusCalculatorUI : Form
    {
        public BonusCalculatorUI()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            double bonus;
            double salary = Convert.ToDouble(salaryTextBox.Text);
            if (salary >= 8000 && salary <= 10000)
            {
                bonus = (salary*6)/100;
                bonusTextBox.Text = Convert.ToString(bonus);

            }
            
            
                
            
            else if (salary > 10000 )
            {
                bonus = (salary * 5) / 100;
                bonusTextBox.Text = Convert.ToString(bonus);

            } 
        }
    }
}
