using System;

namespace FileUtility
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드


        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_FileMove = new System.Windows.Forms.Button();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.FolderNameLabel = new System.Windows.Forms.Label();
            this.FileExtensionLabel = new System.Windows.Forms.Label();
            this.ExtensionTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SourcePathLabel = new System.Windows.Forms.Label();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.m_FileMoveTab = new System.Windows.Forms.TabPage();
            this.m_FileCopyTab = new System.Windows.Forms.TabPage();
            this.m_SourceExtentionTextBox = new System.Windows.Forms.TextBox();
            this.m_SourceExtentionLabel = new System.Windows.Forms.Label();
            this.m_FileCopyButton = new System.Windows.Forms.Button();
            this.m_SourcePathTextBox = new System.Windows.Forms.TextBox();
            this.m_SourcePathLabel = new System.Windows.Forms.Label();
            this.m_DestinationPathTextBox = new System.Windows.Forms.TextBox();
            this.m_CopyDestinationLabel = new System.Windows.Forms.Label();
            this.m_CopyExtentionTextbox = new System.Windows.Forms.TextBox();
            this.m_CopyExtentionLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.m_FileMoveTab.SuspendLayout();
            this.m_FileCopyTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_FileMove
            // 
            this.Button_FileMove.Location = new System.Drawing.Point(357, 154);
            this.Button_FileMove.Name = "Button_FileMove";
            this.Button_FileMove.Size = new System.Drawing.Size(75, 23);
            this.Button_FileMove.TabIndex = 0;
            this.Button_FileMove.Text = "Move";
            this.Button_FileMove.UseVisualStyleBackColor = true;
            this.Button_FileMove.Click += new System.EventHandler(this.Button_MoveFiles);
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(119, 6);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(120, 21);
            this.FolderTextBox.TabIndex = 1;
            // 
            // FolderNameLabel
            // 
            this.FolderNameLabel.AutoSize = true;
            this.FolderNameLabel.Location = new System.Drawing.Point(8, 9);
            this.FolderNameLabel.Name = "FolderNameLabel";
            this.FolderNameLabel.Size = new System.Drawing.Size(78, 12);
            this.FolderNameLabel.TabIndex = 2;
            this.FolderNameLabel.Text = "Folder Name";
            // 
            // FileExtensionLabel
            // 
            this.FileExtensionLabel.AutoSize = true;
            this.FileExtensionLabel.Location = new System.Drawing.Point(8, 36);
            this.FileExtensionLabel.Name = "FileExtensionLabel";
            this.FileExtensionLabel.Size = new System.Drawing.Size(85, 12);
            this.FileExtensionLabel.TabIndex = 4;
            this.FileExtensionLabel.Text = "File Extension";
            // 
            // ExtensionTextBox
            // 
            this.ExtensionTextBox.Location = new System.Drawing.Point(119, 33);
            this.ExtensionTextBox.Name = "ExtensionTextBox";
            this.ExtensionTextBox.Size = new System.Drawing.Size(120, 21);
            this.ExtensionTextBox.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_SelectSourcePath);
            // 
            // SourcePathLabel
            // 
            this.SourcePathLabel.AutoSize = true;
            this.SourcePathLabel.Location = new System.Drawing.Point(8, 87);
            this.SourcePathLabel.Name = "SourcePathLabel";
            this.SourcePathLabel.Size = new System.Drawing.Size(101, 12);
            this.SourcePathLabel.TabIndex = 8;
            this.SourcePathLabel.Text = "SourcePathLabel";
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(119, 84);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.ReadOnly = true;
            this.SourceTextBox.Size = new System.Drawing.Size(313, 21);
            this.SourceTextBox.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem1});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.FileToolStripMenuItem.Text = " 파일";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // FileToolStripMenuItem1
            // 
            this.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1";
            this.FileToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.FileToolStripMenuItem1.Text = "설정";
            this.FileToolStripMenuItem1.Click += new System.EventHandler(this.FileToolStripMenuItem_Click_Setting);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(436, 224);
            this.tabControl1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Extension";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(357, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_SelectSourcePath);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(313, 21);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "SourcePathLabel";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.m_FileMoveTab);
            this.tabControl2.Controls.Add(this.m_FileCopyTab);
            this.tabControl2.Location = new System.Drawing.Point(12, 27);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(471, 224);
            this.tabControl2.TabIndex = 10;
            // 
            // m_FileMoveTab
            // 
            this.m_FileMoveTab.Controls.Add(this.label1);
            this.m_FileMoveTab.Controls.Add(this.label3);
            this.m_FileMoveTab.Controls.Add(this.Button_FileMove);
            this.m_FileMoveTab.Controls.Add(this.FolderTextBox);
            this.m_FileMoveTab.Controls.Add(this.textBox3);
            this.m_FileMoveTab.Controls.Add(this.SourcePathLabel);
            this.m_FileMoveTab.Controls.Add(this.FolderNameLabel);
            this.m_FileMoveTab.Controls.Add(this.button3);
            this.m_FileMoveTab.Controls.Add(this.textBox1);
            this.m_FileMoveTab.Controls.Add(this.SourceTextBox);
            this.m_FileMoveTab.Controls.Add(this.ExtensionTextBox);
            this.m_FileMoveTab.Controls.Add(this.label2);
            this.m_FileMoveTab.Controls.Add(this.FileExtensionLabel);
            this.m_FileMoveTab.Controls.Add(this.button2);
            this.m_FileMoveTab.Controls.Add(this.textBox2);
            this.m_FileMoveTab.Location = new System.Drawing.Point(4, 22);
            this.m_FileMoveTab.Name = "m_FileMoveTab";
            this.m_FileMoveTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_FileMoveTab.Size = new System.Drawing.Size(463, 198);
            this.m_FileMoveTab.TabIndex = 0;
            this.m_FileMoveTab.Text = "FileMove";
            this.m_FileMoveTab.UseVisualStyleBackColor = true;
            // 
            // m_FileCopyTab
            // 
            this.m_FileCopyTab.Controls.Add(this.m_SourceExtentionTextBox);
            this.m_FileCopyTab.Controls.Add(this.m_SourceExtentionLabel);
            this.m_FileCopyTab.Controls.Add(this.m_FileCopyButton);
            this.m_FileCopyTab.Controls.Add(this.m_SourcePathTextBox);
            this.m_FileCopyTab.Controls.Add(this.m_SourcePathLabel);
            this.m_FileCopyTab.Controls.Add(this.m_DestinationPathTextBox);
            this.m_FileCopyTab.Controls.Add(this.m_CopyDestinationLabel);
            this.m_FileCopyTab.Controls.Add(this.m_CopyExtentionTextbox);
            this.m_FileCopyTab.Controls.Add(this.m_CopyExtentionLabel);
            this.m_FileCopyTab.Location = new System.Drawing.Point(4, 22);
            this.m_FileCopyTab.Name = "m_FileCopyTab";
            this.m_FileCopyTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_FileCopyTab.Size = new System.Drawing.Size(463, 198);
            this.m_FileCopyTab.TabIndex = 1;
            this.m_FileCopyTab.Text = "FileCopy";
            this.m_FileCopyTab.UseVisualStyleBackColor = true;
            // 
            // m_SourceExtentionTextBox
            // 
            this.m_SourceExtentionTextBox.Location = new System.Drawing.Point(109, 36);
            this.m_SourceExtentionTextBox.Name = "m_SourceExtentionTextBox";
            this.m_SourceExtentionTextBox.Size = new System.Drawing.Size(100, 21);
            this.m_SourceExtentionTextBox.TabIndex = 8;
            // 
            // m_SourceExtentionLabel
            // 
            this.m_SourceExtentionLabel.AutoSize = true;
            this.m_SourceExtentionLabel.Location = new System.Drawing.Point(6, 39);
            this.m_SourceExtentionLabel.Name = "m_SourceExtentionLabel";
            this.m_SourceExtentionLabel.Size = new System.Drawing.Size(101, 12);
            this.m_SourceExtentionLabel.TabIndex = 7;
            this.m_SourceExtentionLabel.Text = "Source Extention";
            // 
            // m_FileCopyButton
            // 
            this.m_FileCopyButton.Location = new System.Drawing.Point(366, 169);
            this.m_FileCopyButton.Name = "m_FileCopyButton";
            this.m_FileCopyButton.Size = new System.Drawing.Size(75, 23);
            this.m_FileCopyButton.TabIndex = 6;
            this.m_FileCopyButton.Text = "Copy";
            this.m_FileCopyButton.UseVisualStyleBackColor = true;
            // 
            // m_SourcePathTextBox
            // 
            this.m_SourcePathTextBox.Location = new System.Drawing.Point(109, 126);
            this.m_SourcePathTextBox.Name = "m_SourcePathTextBox";
            this.m_SourcePathTextBox.Size = new System.Drawing.Size(332, 21);
            this.m_SourcePathTextBox.TabIndex = 5;
            // 
            // m_SourcePathLabel
            // 
            this.m_SourcePathLabel.AutoSize = true;
            this.m_SourcePathLabel.Location = new System.Drawing.Point(6, 135);
            this.m_SourcePathLabel.Name = "m_SourcePathLabel";
            this.m_SourcePathLabel.Size = new System.Drawing.Size(74, 12);
            this.m_SourcePathLabel.TabIndex = 4;
            this.m_SourcePathLabel.Text = "Source Path";
            // 
            // m_DestinationPathTextBox
            // 
            this.m_DestinationPathTextBox.Location = new System.Drawing.Point(109, 69);
            this.m_DestinationPathTextBox.Name = "m_DestinationPathTextBox";
            this.m_DestinationPathTextBox.Size = new System.Drawing.Size(332, 21);
            this.m_DestinationPathTextBox.TabIndex = 3;
            // 
            // m_CopyDestinationLabel
            // 
            this.m_CopyDestinationLabel.AutoSize = true;
            this.m_CopyDestinationLabel.Location = new System.Drawing.Point(6, 72);
            this.m_CopyDestinationLabel.Name = "m_CopyDestinationLabel";
            this.m_CopyDestinationLabel.Size = new System.Drawing.Size(96, 12);
            this.m_CopyDestinationLabel.TabIndex = 2;
            this.m_CopyDestinationLabel.Text = "Destination Path";
            // 
            // m_CopyExtentionTextbox
            // 
            this.m_CopyExtentionTextbox.Location = new System.Drawing.Point(109, 9);
            this.m_CopyExtentionTextbox.Name = "m_CopyExtentionTextbox";
            this.m_CopyExtentionTextbox.Size = new System.Drawing.Size(100, 21);
            this.m_CopyExtentionTextbox.TabIndex = 1;
            // 
            // m_CopyExtentionLabel
            // 
            this.m_CopyExtentionLabel.AutoSize = true;
            this.m_CopyExtentionLabel.Location = new System.Drawing.Point(6, 12);
            this.m_CopyExtentionLabel.Name = "m_CopyExtentionLabel";
            this.m_CopyExtentionLabel.Size = new System.Drawing.Size(97, 12);
            this.m_CopyExtentionLabel.TabIndex = 0;
            this.m_CopyExtentionLabel.Text = "Target Extention";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 269);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FileUtility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.m_FileMoveTab.ResumeLayout(false);
            this.m_FileMoveTab.PerformLayout();
            this.m_FileCopyTab.ResumeLayout(false);
            this.m_FileCopyTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void LoadExtentionSetting(FileMoveSetting setting)
        {
            ExtensionTextBox.Text = setting.Extention;
            FolderTextBox.Text = setting.DestinationFolderName;
        }



        #endregion
        private System.Windows.Forms.Label FolderNameLabel;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Label FileExtensionLabel;
        private System.Windows.Forms.TextBox ExtensionTextBox;
        private System.Windows.Forms.Button Button_FileMove;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label SourcePathLabel;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        
        
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage m_FileMoveTab;

        /// <summary>
        /// filecopy UI
        /// </summary>
        private System.Windows.Forms.TabPage m_FileCopyTab;
        private System.Windows.Forms.Label m_CopyExtentionLabel;
        private System.Windows.Forms.TextBox m_CopyExtentionTextbox;
        private System.Windows.Forms.Label m_CopyDestinationLabel;
        private System.Windows.Forms.TextBox m_DestinationPathTextBox;
        private System.Windows.Forms.Label m_SourcePathLabel;
        private System.Windows.Forms.TextBox m_SourcePathTextBox;
        private System.Windows.Forms.Button m_FileCopyButton;

        private System.Windows.Forms.TextBox m_SourceExtentionTextBox;
        private System.Windows.Forms.Label m_SourceExtentionLabel;
    }
}

