using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ActUtlType plc = new ActUtlType();

        private void Button4_Click(object sender, EventArgs e)
        {
            plc.ActLogicalStationNumber = 20;
            plc.Open();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            plc.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int read_result;
            plc.GetDevice(textBox1.Text, out read_result);
            textBox2.Text = read_result.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            plc.SetDevice(textBox1.Text, Convert.ToInt16(textBox2.Text));
        }
    }
}
