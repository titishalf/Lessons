using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculato
{
    public partial class Calculatore : Form
    {
        public Calculatore()
        {
            InitializeComponent();
        }

        /* private void groupBox1_Enter(object sender, EventArgs e)
         {

         }

         private void Plus_Click(object sender, EventArgs e)
         {
             var obj = new Funcz();
             var a = Convert.ToInt16(var1.Text);
             var b = Convert.ToInt16(var2.Text);
             ans.Text = Convert.ToString(obj.Add(a, b));
         }

         private void Minus_Click(object sender, EventArgs e)
         {
             var obj = new Funcz();
             var a = Convert.ToInt16(var1.Text);
             var b = Convert.ToInt16(var2.Text);
             ans.Text = Convert.ToString(obj.Sub(a, b));
         }

         private void Div_Click(object sender, EventArgs e)
         {
             ar obj = new Funcz();
             var a = Convert.ToInt16(var1.Text);
             var b = Convert.ToInt16(var2.Text);
             ans.Text = Convert.ToString(obj.Div(a, b));
         }*/

        private void button1_Click(object sender, EventArgs e)
        {
            var obj = new Funcz();
            var a = Convert.ToInt16(fir.Text);
            var b = Convert.ToInt16(sec.Text);
            res.Text = Convert.ToString(obj.Add(a, b));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var obj = new Funcz();
            var a = Convert.ToInt16(fir.Text);
            var b = Convert.ToInt16(sec.Text);
            res.Text = Convert.ToString(obj.Sub(a, b));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var obj = new Funcz();
            var a = Convert.ToInt16(fir.Text);
            var b = Convert.ToInt16(sec.Text);
            res.Text = Convert.ToString(obj.Mul(a, b));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var obj = new Funcz();
            var a = Convert.ToInt16(fir.Text);
            var b = Convert.ToInt16(sec.Text);
            res.Text = Convert.ToString(obj.Div(a, b));
        }
    }
}
