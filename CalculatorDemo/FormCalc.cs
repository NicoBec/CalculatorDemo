using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDemo
{
    public partial class frmCalculator : Form
    {
        //This is the Calculator Object used in this form
        private CalculatorEngine Calc = new CalculatorEngine();

        public frmCalculator()
        {
            InitializeComponent();
        }

        #region AllEvents
        #region numPad
        private void btnDot_Click(object sender, EventArgs e)
        {
            addDot();

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
        #endregion

        #region Operations
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DoCalc(CalculationOperator.add);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            DoCalc(CalculationOperator.subtract);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            DoCalc(CalculationOperator.divide);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            DoCalc(CalculationOperator.multiply);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            doEqualCacl();
        }

        private void doEqualCacl()
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = Calc.ReturnStoredValue().ToString();
            }
            else
            {
                txtDisplay.Text = Calc.DoCalculation(Double.Parse(txtDisplay.Text)).ToString();
            }
            resetCursor();
        }

        private void DoCalc(CalculationOperator oper)
        {
            Calc.DoCalculation(Double.Parse(txtDisplay.Text));
            Calc.AddCalcOperator(oper);
            clearText();
        }


        #endregion

        #region OtherEvents
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Calc.ResetAll();
            clearText();
        }

        private void btnClearDisplay_Click(object sender, EventArgs e)
        {
            clearText();
        }
        #endregion
        #endregion

        #region FormFunctionality
        /// <summary>
        /// This will add the string to the display
        /// </summary>
        /// <param name="val">String to add</param>
        private void addToScreen(string val)
        {
            txtDisplay.Text = formatTxt(txtDisplay.Text, val);
            resetCursor();
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
        /// This will add the dot if the dot is allowed
        /// </summary>
        private void addDot()
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

        /// <summary>
        /// The cursor needs to stay on the right almost all the time
        /// </summary>
        private void resetCursor()
        {
            txtDisplay.Select(txtDisplay.Text.Length, 0);
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

        /// <summary>
        /// This will set the text back to a 0
        /// </summary>
        private void clearText()
        {
            txtDisplay.Text = "0";
            resetCursor();
        }

        #endregion



        #region Memory
        private void btmMemAdd_Click(object sender, EventArgs e)
        {
            Calc.MemoryAdd(Double.Parse(txtDisplay.Text));
        }

        private void btnMemSub_Click(object sender, EventArgs e)
        {
            Calc.MemorySubtract(Double.Parse(txtDisplay.Text));
        }

        private void btnMemRecall_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Calc.MemoryGetValue().ToString();
        }

        private void btnMemClear_Click(object sender, EventArgs e)
        {
            Calc.MemoryClear();
        }
        #endregion

        #region NumPad

        /// <summary>
        /// This will handle all the input and filter it so that the numpad will work
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this is the string of the key that was pressed
            string chr = e.KeyChar.ToString();
            int i;

            if (int.TryParse(chr, out i))
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "";
                }
            }
            else
            {
                //This will stop the key form being inserted into the textbox
                e.Handled = true;

                switch (chr)
                {
                    case "/":
                        DoCalc(CalculationOperator.divide);
                        break;
                    case "+":
                        DoCalc(CalculationOperator.add);
                        break;
                    case "-":
                        DoCalc(CalculationOperator.subtract);
                        break;
                    case "*":
                        DoCalc(CalculationOperator.multiply);
                        break;
                    case "\r":
                        doEqualCacl();

                        break;
                    case ".":
                        addDot();
                        break;
                    case "\b":
                        {
                            if (txtDisplay.Text != "")
                            {
                                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);

                            }
                            break;
                        }

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// This is to ensure the focus stays on the textbox
        /// </summary>
        private void txtDisplay_Leave(object sender, EventArgs e)
        {
            txtDisplay.Focus();
            resetCursor();
        }
        #endregion
    }
}
