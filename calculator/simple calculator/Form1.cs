using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;s
using System.Windows.Forms;

namespace calculato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form p;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            switch (node.Text)
            {
                case "Calculator":
                    p.Dispose();
                    p = new Calculatore();
                    p.TopLevel = false;
                    this.mainpanel.Controls.Add(p);
                    p.Dock = DockStyle.Fill;
                    p.Show();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes[0].ExpandAll();
            p = new Calculatore();

            p.TopLevel = false;
            this.mainpanel.Controls.Add(p);
            p.Dock = DockStyle.Fill;
        }
    }
}
    
