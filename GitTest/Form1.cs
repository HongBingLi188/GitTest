using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //添加Load
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region MyRegion

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBox1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBox2");
        }
    }
}
