namespace FileUtility
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_Save_button = new System.Windows.Forms.Button();
            this.m_StartSettingLoadCheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // m_Save_button
            // 
            this.m_Save_button.Location = new System.Drawing.Point(365, 269);
            this.m_Save_button.Name = "m_Save_button";
            this.m_Save_button.Size = new System.Drawing.Size(75, 23);
            this.m_Save_button.TabIndex = 0;
            this.m_Save_button.Text = "저장";
            this.m_Save_button.UseVisualStyleBackColor = true;
            this.m_Save_button.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // m_StartSettingLoadCheck
            // 
            this.m_StartSettingLoadCheck.AutoSize = true;
            this.m_StartSettingLoadCheck.Location = new System.Drawing.Point(12, 12);
            this.m_StartSettingLoadCheck.Name = "m_StartSettingLoadCheck";
            this.m_StartSettingLoadCheck.Size = new System.Drawing.Size(132, 16);
            this.m_StartSettingLoadCheck.TabIndex = 1;
            this.m_StartSettingLoadCheck.Text = "시작 시 설정값 적용";
            this.m_StartSettingLoadCheck.UseVisualStyleBackColor = true;
            this.m_StartSettingLoadCheck.CheckedChanged += new System.EventHandler(this.StartLoadState_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 183);
            this.panel1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_StartSettingLoadCheck);
            this.Controls.Add(this.m_Save_button);
            this.Name = "Form2";
            this.Text = "설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button m_Save_button;
        private System.Windows.Forms.CheckBox m_StartSettingLoadCheck;
        private System.Windows.Forms.Panel panel1;
    }
}