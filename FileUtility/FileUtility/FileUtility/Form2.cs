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
        public static bool isWindowLoad = false;

        private bool isStartLoad = false;
        public Form2(bool ison)
        {
            InitializeComponent();
            isWindowLoad = true;
            Closed += Form2_Closed;
            m_StartSettingLoadCheck.Checked = ison;
        }

        private void Form2_Closed(object sender, System.EventArgs e)
        {
            isWindowLoad = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void StartLoadState_CheckedChanged(object sender, EventArgs e)
        {
            isStartLoad = !isStartLoad;
            StartSettingManager.ChangeStartLoadState(isStartLoad);
        }
    }
}
