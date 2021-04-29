using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _7._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxColor.Items.Add("Red");
            comboBoxColor.Items.Add("Blue");
            comboBoxColor.Items.Add("Yellow");
        }
        
        //以下为课本中例5-31源代码
        private Graphics graphics;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;
        private double per1 = 0.6;
        private double per2 = 0.7;
        private int n = 10;
        private int length = 100;
        Pen pen = Pens.Blue;


        private void drawCayleyTree(int n, double x0, double y0, double length, double th)
        {
            if (n == 0) return;

            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);
            
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * length, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * length, th - th2);

        }

        private void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                pen,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }
        //以下内容结合可以确定的参数进行修改
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = panel1.CreateGraphics();
            graphics.Clear(Color.White);
            drawCayleyTree(n, 200, 310, length, -Math.PI / 2);
        }
        
        
        //视觉效果有关combobox设置
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxColor.Text)
            {
                case "Red":
                    pen = Pens.Red;
                    break;
                case "Blue":
                    pen = Pens.Blue;
                    break;
                case "Yellow":
                    pen = Pens.Yellow;
                    break;
                default:
                    break;

            }
        }
        //参数设置有关textbox的设置
        private void textBoxN_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxN.Text) <= 0) { textBoxN.Text = "1"; }
            else if (Int32.Parse(textBoxN.Text) >= 20) { textBoxN.Text = "20"; }
            else { n = Int32.Parse(textBoxN.Text); }
        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxLength.Text) <= 0) { textBoxLength.Text = "1"; }
            else if(Int32.Parse(textBoxLength.Text) >= 100) { textBoxLength.Text = "100"; }
            else { length = Int32.Parse(textBoxLength.Text); }
        }

        private void textBoxRLrate_TextChanged(object sender, EventArgs e)
        {
            if (double.Parse(textBoxRLrate.Text) < 0) { textBoxRLrate.Text = "0"; }
            else if (double.Parse(textBoxRLrate.Text) > 1) { textBoxRLrate.Text = "1"; }
            else { per2 = double.Parse(textBoxRLrate.Text); }

        }

        private void textBoxLLrate_TextChanged(object sender, EventArgs e)
        {
            if (double.Parse(textBoxLLrate.Text) < 0) { textBoxLLrate.Text = "0"; }
            else if (double.Parse(textBoxLLrate.Text) > 1) { textBoxLLrate.Text = "1"; }
            else { per1 = double.Parse(textBoxLLrate.Text); }
        }

        private void textBoxRdegree_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxRdegree.Text) < 0) { textBoxRdegree.Text = "0"; }
            else if (Int32.Parse(textBoxRdegree.Text) >= 100) { textBoxRdegree.Text = "100"; }
            else { th2 = Int32.Parse(textBoxRdegree.Text) * Math.PI / 180; }

        }

        private void textBoxLdegree_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxLdegree.Text) < 0) { textBoxLdegree.Text = "0"; }
            else if (Int32.Parse(textBoxLdegree.Text) >= 100) { textBoxLdegree.Text = "100"; }
            else { th1 = Int32.Parse(textBoxLdegree.Text) * Math.PI / 180; }
        }
    }
}
