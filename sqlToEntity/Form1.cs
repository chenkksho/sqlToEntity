using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlToEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string attr = "[sss Column(Name={0})]";
        private string pre = "public";


        private void button1_Click(object sender, EventArgs e)
        {
            var sourceStr = this.richTextBox1.Text;
            var lstSourceField = sourceStr.Split('\n');
            var lstField = new List<string>();
            foreach (var item in lstSourceField)
            {
                lstField.Add(new System.Text.RegularExpressions.Regex("[\\s]+").Replace(item, " "));
            }

        }
    }
}
