using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COOKERY_BOOK
{
    public partial class Form2 : Form
    {
        public TreeNode SelectNode { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void AddNode(string nodeName, string nodeValue)
        {
            SelectNode.Nodes.Add(nodeName, nodeValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Text) & !String.IsNullOrEmpty(Text))
            {
                AddNode(Text, Text);
            }
        }
    }
}
