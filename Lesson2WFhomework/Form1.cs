using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2WFhomework
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn_9_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = Color.Gray;
        }

        private void btn_9_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = Color.White;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (lbl_result.Text.Length == 1 && lbl_result.Text == "0")
                {
                    lbl_result.Text = "";
                    lbl_result.Text += btn.Text;
                }
                else
                {
                    lbl_result.Text += btn.Text;
                }
            }
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (lbl_result.Text.Length > 0)
                lbl_result.Text = lbl_result.Text.Remove(lbl_result.Text.Length - 1);
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (!(lbl_result.Text == "0"))
                {
                    if (lbl_result.Text.Length >= 2
                        && lbl_result.Text[lbl_result.Text.Length - 2].ToString() != btn_mult.Text
                        && lbl_result.Text[lbl_result.Text.Length - 2].ToString() != btn_subt.Text
                        && lbl_result.Text[lbl_result.Text.Length - 2].ToString() != btn_devide.Text
                        && lbl_result.Text[lbl_result.Text.Length - 2].ToString() != btn_sum.Text)
                    {
                        lbl_result.Text += $" {btn.Text} ";
                    }
                    else if (lbl_result.Text.Length == 1) 
                        lbl_result.Text += $" {btn.Text} ";
                }
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            List<string> rslt= lbl_result.Text.Split(' ').ToList();
            
            if (rslt.Count == 3)
            {
                if (rslt[1] == btn_mult.Text)
                    lbl_result.Text = (int.Parse(rslt[0]) * int.Parse(rslt[2])).ToString();
                else if (rslt[1] == btn_sum.Text)
                    lbl_result.Text = (int.Parse(rslt[0]) + int.Parse(rslt[2])).ToString();
                else if (rslt[1] == btn_subt.Text)
                    lbl_result.Text = (int.Parse(rslt[0]) - int.Parse(rslt[2])).ToString();
                else if (rslt[1] == btn_devide.Text && rslt[2] != "0")
                    lbl_result.Text = (int.Parse(rslt[0]) / int.Parse(rslt[2])).ToString();
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "0";
        }
    }
}
