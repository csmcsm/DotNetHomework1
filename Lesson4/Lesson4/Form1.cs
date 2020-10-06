using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson4
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int n;
        double x0; double y0; double leng; double th;
        Pen p { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
      
        public void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void DrawLine(double x0, double y0, double x1, double y1)
        {
           
            graphics.DrawLine(p,
                (int)x0, (int)y0, (int)x1, (int)y1);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen[] ps = { Pens.Red, Pens.Black, Pens.Blue };
            try
            {
                p = ps[comboBox1.SelectedIndex];
                n = int.Parse(textBox1.Text);
                leng = double.Parse(textBox2.Text);
                per1 = double.Parse
                    (textBox3.Text);
                per2 = double.Parse
                   (textBox4.Text);
                th1 = double.Parse
                    (textBox6.Text);
                th2 = double.Parse
                   (textBox3.Text);
            
                if (graphics == null) graphics = this.CreateGraphics();
                graphics.Clear(Color.White);
            }
            catch { 
            }
            DrawCayleyTree(n, x0, y0, leng, th);
        }

      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
