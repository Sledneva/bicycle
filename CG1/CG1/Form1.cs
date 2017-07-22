using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //e.Graphics.DrawEllipse(Pens.Black, 0,0,100,100);
            //Graphics g = e.Graphics;
            Graphics g = this.CreateGraphics();
            try
            {
                //g.DrawLine(Pens.Black, new Point(0,0), new Point(30, 50)); 
                MyClass c = new MyClass();
                c.Draw(g);
            }
            finally
            {
                if (g != null)
                    ((IDisposable)g).Dispose();
            }
        }

        private void Form1_MouseMove(object sender,
            MouseEventArgs e)
        {
            Text = Convert.ToString(e.X) + " " +
                Convert.ToString(e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawEllipse(Pens.Black, 0,0,100,100);
            //Graphics g = e.Graphics;
            Graphics g = this.CreateGraphics();
            try
            {
                //g.DrawLine(Pens.Black, new Point(0,0), new Point(30, 50)); 
                MyClass c = new MyClass();
                c.Draw(g);
            }
            finally
            {
                if (g != null)
                    ((IDisposable)g).Dispose();
            }
        }
    }
}
