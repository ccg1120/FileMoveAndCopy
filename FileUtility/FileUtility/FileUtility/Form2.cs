using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUtility
{
    public partial class Form2 : Form
    {
        public static bool isLoad = false;

        private bool isStartLoad = false;
        public Form2()
        {
            InitializeComponent();
            isLoad = true;
            Closed += Form2_Closed;

        }

        private void Form2_Closed(object sender, System.EventArgs e)
        {
            isLoad = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void StartLoadState_CheckedChanged(object sender, EventArgs e)
        {
            isStartLoad = !isStartLoad;
        }
    }
}
