using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicapp
{
    public partial class Form1 : Form
    {
        int LabelTop = 50;
        int LabelTop2 = 50;
        int LabelLeft = 350;
        int LabelLeft2 = 450;
        Label lbl2 = new Label();
        Label lbl4 = new Label();
        bool start = true;
        bool start2 = true;
        public Form1()
        {
            InitializeComponent();
        }

        public void Calculate()
        {
            // Gets the users input
            string x1 = mm1_text1.Text;
            string y1 = mm1_text2.Text;
            string amount1 = Amount1.Text;

            try
            {
                float intx1 = Convert.ToInt32(x1);
                float inty1 = Convert.ToInt32(y1);
                float intamount1 = Convert.ToInt32(amount1);


                // Makes the calculation
                float calc1 = intx1 * inty1 * intamount1;
                float calc2 = (intx1 * inty1) / 100 * intamount1;
                float calc3 = (intx1 * inty1) / 1000000 * intamount1;
                answer1_t1.Text = calc1.ToString() + " mm2";
                answer1_t2.Text = calc2.ToString() + " cm2";
                answer1_t3.Text = calc3.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Use Numbers");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
            if (checkBox1.Checked)
            {
                newLabel(LabelTop, LabelLeft);
            }
            LabelTop = LabelTop + 21;
        }

        private void newLabel(int PosTop, int PosLeft)
        {
            Label lbl = new Label();
            this.Controls.Add(lbl);
            lbl.Top = PosTop;
            lbl.Left = PosLeft;
            lbl.ForeColor = Color.Gray;
            lbl.Text = answer1_t3.Text;

            this.Controls.Add(lbl2);
            lbl2.Top = PosTop + 21;
            lbl2.Left = PosLeft;
            if (start == true)
            {
                lbl2.Text = "0";
                start = false;
            }
            lbl2.ForeColor = Color.White;
            float floatanswer = float.Parse(lbl2.Text);
            float floatlbl = float.Parse(lbl.Text);
            float equals = floatanswer + floatlbl;
            lbl2.Text = equals.ToString();
        }

        public void Calculate2()
        {
            // Gets the user input
            string x2 = mm2_text1.Text;
            string y2 = mm2_text2.Text;
            string z2 = mm2_text3.Text;
            string amount2 = Amount2.Text;

            try
            {
                float intx2 = Convert.ToInt32(x2);
                float inty2 = Convert.ToInt32(y2);
                float intz2 = Convert.ToInt32(z2);
                float intamount2 = Convert.ToInt32(amount2);

                // Makes the calcualtion
                float calc4 = intx2 * inty2 * intz2 * intamount2;
                float calc5 = (intx2 * inty2 * intz2) / 1000 * intamount2;
                float calc6 = (intx2 * inty2 * intz2) / 1000000000 * intamount2;
                answer2_t1.Text = calc4.ToString() + " mm3";
                answer2_t2.Text = calc5.ToString() + " cm3";
                answer2_t3.Text = calc6.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Use Numbers");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate2();
            if (checkBox2.Checked)
            {
                newLabel2(LabelTop2, LabelLeft2);
            }
            LabelTop2 = LabelTop2 + 21;
        }

        private void newLabel2(int PosTop, int PosLeft)
        {
            Label lbl3 = new Label();
            this.Controls.Add(lbl3);
            lbl3.Top = PosTop;
            lbl3.Left = PosLeft;
            lbl3.ForeColor = Color.Gray;
            lbl3.Text = answer2_t3.Text;

            this.Controls.Add(lbl4);
            lbl4.Top = PosTop + 21;
            lbl4.Left = PosLeft;
            if (start2 == true)
            {
                lbl4.Text = "0";
                start2 = false;
            }
            lbl4.ForeColor = Color.White;
            float floatanswer = float.Parse(lbl4.Text);
            float floatlbl = float.Parse(lbl3.Text);
            float equals = floatanswer + floatlbl;
            lbl4.Text = equals.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Size = new Size(600, 600);
            }
            else
            {
                if (!checkBox2.Checked)
                {
                    Size = new Size(300, 600);
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Size = new Size(600, 600);
            }
            else
            {
                if (!checkBox1.Checked)
                {
                    Size = new Size(300, 600);
                }
            }
        }
    }
}
