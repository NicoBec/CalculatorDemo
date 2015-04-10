using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDemo
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                if (txtDisplay.Text == "")
                {
                    addToScreen("0.");
                }
                else
                {
                    addToScreen(".");
                }
            }

        }

        private void btnBsp_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            addToScreen("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addToScreen("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            addToScreen("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addToScreen("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addToScreen("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addToScreen("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addToScreen("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            addToScreen("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addToScreen("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addToScreen("9");
        }

        /// <summary>
        /// This will add the string to the display
        /// </summary>
        /// <param name="val">String to add</param>
        private void addToScreen(string val)
        {
            txtDisplay.Text = formatTxt(txtDisplay.Text, val);
        }

        /// <summary>
        /// This function will add and validate the user input that apply to all of the inputs. 
        /// Validation for individual inputs are done in the event handler
        /// </summary>
        /// <param name="val">this is the current display text</param>
        /// <param name="add">this is the value being added</param>
        /// <returns>The string value of the display including the newly added value</returns>
        private string formatTxt(string val, string add)
        {

            val += add;

            return leadZeroremove(val);
        }

        /// <summary>
        /// This will remove any leading Zero from the display
        /// </summary>
        /// <param name="val">String to remove the leading Zero from</param>
        /// <returns>Formatted String</returns>
        private string leadZeroremove(string val)
        {
            Char[] charArrVal = val.ToCharArray();
            bool removeFlag = true;
            while (removeFlag)
            {
                if (charArrVal.Length > 1 && charArrVal[0] == '0' && charArrVal[1] != '.')
                {
                    val = val.Substring(1);
                    charArrVal = val.ToCharArray();
                }
                else
                {
                    removeFlag = false;
                }
            }

            return val;
        }





    }
}
