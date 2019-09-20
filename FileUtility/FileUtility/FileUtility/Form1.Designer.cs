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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_FileMove
            // 
            this.Button_FileMove.Location = new System.Drawing.Point(361, 197);
            this.Button_FileMove.Name = "Button_FileMove";
            this.Button_FileMove.Size = new System.Drawing.Size(75, 23);
            this.Button_FileMove.TabIndex = 0;
            this.Button_FileMove.Text = "Move";
            this.Button_FileMove.UseVisualStyleBackColor = true;
            this.Button_FileMove.Click += new System.EventHandler(this.Button_MoveFiles);
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(123, 49);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(120, 21);
            this.FolderTextBox.TabIndex = 1;
            // 
            // FolderNameLabel
            // 
            this.FolderNameLabel.AutoSize = true;
            this.FolderNameLabel.Location = new System.Drawing.Point(12, 52);
            this.FolderNameLabel.Name = "FolderNameLabel";
            this.FolderNameLabel.Size = new System.Drawing.Size(78, 12);
            this.FolderNameLabel.TabIndex = 2;
            this.FolderNameLabel.Text = "Folder Name";
            // 
            // FileExtensionLabel
            // 
            this.FileExtensionLabel.AutoSize = true;
            this.FileExtensionLabel.Location = new System.Drawing.Point(12, 79);
            this.FileExtensionLabel.Name = "FileExtensionLabel";
            this.FileExtensionLabel.Size = new System.Drawing.Size(85, 12);
            this.FileExtensionLabel.TabIndex = 4;
            this.FileExtensionLabel.Text = "File Extension";
            // 
            // ExtensionTextBox
            // 
            this.ExtensionTextBox.Location = new System.Drawing.Point(123, 76);
            this.ExtensionTextBox.Name = "ExtensionTextBox";
            this.ExtensionTextBox.Size = new System.Drawing.Size(120, 21);
            this.ExtensionTextBox.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 154);
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
            this.SourcePathLabel.Location = new System.Drawing.Point(12, 130);
            this.SourcePathLabel.Name = "SourcePathLabel";
            this.SourcePathLabel.Size = new System.Drawing.Size(101, 12);
            this.SourcePathLabel.TabIndex = 8;
            this.SourcePathLabel.Text = "SourcePathLabel";
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(123, 127);
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
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem1});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.FileToolStripMenuItem.Text = " 파일";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // 설정ToolStripMenuItem1
            // 
            this.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1";
            this.FileToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.FileToolStripMenuItem1.Text = "설정";
            this.FileToolStripMenuItem1.Click += new System.EventHandler(this.FileToolStripMenuItem_Click_Setting);

            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 236);
            this.Controls.Add(this.SourcePathLabel);
            this.Controls.Add(this.SourceTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FileExtensionLabel);
            this.Controls.Add(this.ExtensionTextBox);
            this.Controls.Add(this.FolderNameLabel);
            this.Controls.Add(this.FolderTextBox);
            this.Controls.Add(this.Button_FileMove);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FileUtility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

