using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_gpa_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m1.Text == "" || m2.Text == "" || m3.Text == "" || m4.Text == "" || m5.Text == "" || m0.Text == "" || cb0.Text == "" || cb1.Text == "" || cb2.Text == "" || cb3.Text == "" || cb4.Text == "" || cb5.Text == "")
            {
                MessageBox.Show("  All entities should be filled");
            }
            else
            {
                float[] n = new float[6];
                int[] cr = new int[6];
                n[0] = Int32.Parse(m0.Text);
                n[1] = Int32.Parse(m1.Text);
                n[2] = Int32.Parse(m2.Text);
                n[3] = Int32.Parse(m3.Text);
                n[4] = Int32.Parse(m4.Text);
                n[5] = Int32.Parse(m5.Text);

                cr[0] = Int32.Parse(cb0.Text);
                cr[1] = Int32.Parse(cb1.Text);
                cr[2] = Int32.Parse(cb2.Text);
                cr[3] = Int32.Parse(cb3.Text);
                cr[4] = Int32.Parse(cb4.Text);
                cr[5] = Int32.Parse(cb5.Text);
                float[] gp = new float[6];
                float totalgp = 0;
                int totalcr = 0;





                if (n[0] < 0 || n[0] > 100 || n[1] < 0 || n[1] > 100 || n[2] < 0 || n[2] > 100 || n[3] < 0 || n[3] > 100 || n[4] < 0 || n[4] > 100 || n[5] < 0 || n[5] > 100)
                {
                    MessageBox.Show("Please enter an valid input");
                }
                else
                {
                    if (ch0.Checked == true)
                    {
                        cr[0] = 0;
                        n[0] = 0;
                        gp[0] = 0;
                    }
                    if (ch1.Checked == true)
                    {
                        cr[1] = 0;
                        n[1] = 0;
                        gp[1] = 0;
                    }
                    if (ch2.Checked == true)
                    {
                        cr[2] = 0;
                        n[2] = 0;
                        gp[2] = 0;
                    }
                    if (ch3.Checked == true)
                    {
                        cr[3] = 0;
                        n[3] = 0;
                        gp[3] = 0;
                    }
                    if (ch4.Checked == true)
                    {
                        cr[4] = 0;
                        n[4] = 0;
                        gp[4] = 0;
                    }
                    if (ch5.Checked == true)
                    {
                        cr[5] = 0;
                        n[5] = 0;
                        gp[5] = 0;
                    }
                    for (int i = 0; i < 6; i++)
                    {
                        /* if (ch[i].Checked== true)
                         {
                             cr[i] = 0;
                             n[i] = 0;
                             gp[i] = 0;
                         }*/
                        if (n[i] >= 80)
                        {
                            gp[i] = cr[i] * 4;
                        }
                        else if (n[i] >= 70 && n[i] < 80)
                        {
                            gp[i] = cr[i] * 3;
                        }
                        else if (n[i] >= 60 && n[i] < 70)
                        {
                            gp[i] = cr[i] * 2;
                        }
                        else if (n[i] >= 50 && n[i] < 60)
                        {
                            gp[i] = cr[i] * 1;
                        }
                        else if (n[i] < 50)
                        {
                            gp[i] = cr[i] * 0;
                        }
                        totalgp += gp[i];
                        totalcr += cr[i];


                    }
                    float gpa = totalgp / totalcr;

                    result.Text = gpa.ToString();
                }
            }
        }
    }
}
