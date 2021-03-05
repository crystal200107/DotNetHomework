using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

       
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
                comboBox1.Items.Add("+");
                comboBox1.Items.Add("-");
                comboBox1.Items.Add("*");
                comboBox1.Items.Add("/");

        }
            string mark;
            double a, b, n;//分别用于储存运算结果和两个运算数

       
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                mark = comboBox1.Text;
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {
                a = int.Parse(textBox1.Text);
            }



            private void textBox2_TextChanged(object sender, EventArgs e)
            {
                b = int.Parse(textBox2.Text);
            }

        



            private void button1_Click(object sender, EventArgs e)
            {
                switch (mark)
                {
                    case "+":
                        n = a + b;
                    label3.Text = n.ToString();
                    break;
                    case "-":
                        n = a - b;
                    label3.Text = n.ToString();
                    break;
                    case "*":
                        n = a * b;
                    label3.Text = n.ToString();
                    break;
                    case "/":
                        if (b == 0)
                        {
                            MessageBox.Show("除数不能为0！");
                            
                        }
                        else
                        {
                            n = a / b;
                        label3.Text = n.ToString();
                    }
                        break;
                    default:
                        MessageBox.Show("错误");
                        break;

                }
              
            }
        }
    }

