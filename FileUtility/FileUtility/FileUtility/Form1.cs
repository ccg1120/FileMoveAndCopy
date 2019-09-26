using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;



namespace FileUtility
{
    public partial class Form1 : Form
    {

        private UtilityManager manager;

        public Form1()
        {
            InitializeComponent();
            manager = new UtilityManager();
        }

        private void Button_MoveFiles(object sneder, EventArgs e)
        {
            // TODO : 파일 이동 명령
            Debug.WriteLine("Click button");
            manager.DestFolderName = this.FolderTextBox.Text;
            manager.FileType = this.ExtensionTextBox.Text;

            manager.FolderPathSetting();
            manager.CreateAction(()=>ShowFinishMessage());
        }



        private void ShowFinishMessage()
        {
            MessageBox.Show("Finish!");
        }
        private void Form1_Load(object sneder, EventArgs e)
        {
            Debug.WriteLine("Form1_Load");
        }

        private void Button_SelectSourcePath(object sneder, EventArgs e)
        {
            FolderBrowserDialog dia = new FolderBrowserDialog();

            dia.Description = "Source path";

            if(dia.ShowDialog() == DialogResult.OK)
            {
                manager.SourceFolderpath = dia.SelectedPath;
                SourceTextBox.Text = manager.SourceFolderpath;
            }
            else
            {
                Debug.WriteLine("DialogResult. OFF");
            }
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FileToolStripMenuItem_Click_Setting(object sender, EventArgs e)
        {
            if (!Form2.isWindowLoad)
            {
                Form2 show2 = new Form2(StartSettingManager.IsStartLoad());
                show2.Visible = true;
            }
        }

      
    }
}
