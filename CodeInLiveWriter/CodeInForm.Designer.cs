namespace CodeInLiveWriter
{
    partial class CodeInForm
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
            this.Language = new System.Windows.Forms.Label();
            this.comboBox_Language = new System.Windows.Forms.ComboBox();
            this.checkBox_ShowLine = new System.Windows.Forms.CheckBox();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Style = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Location = new System.Drawing.Point(15, 17);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(58, 13);
            this.Language.TabIndex = 0;
            this.Language.Text = "Language:";
            // 
            // comboBox_Language
            // 
            this.comboBox_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Language.FormattingEnabled = true;
            this.comboBox_Language.Location = new System.Drawing.Point(79, 12);
            this.comboBox_Language.Name = "comboBox_Language";
            this.comboBox_Language.Size = new System.Drawing.Size(172, 21);
            this.comboBox_Language.TabIndex = 1;
            // 
            // checkBox_ShowLine
            // 
            this.checkBox_ShowLine.AutoSize = true;
            this.checkBox_ShowLine.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_ShowLine.Checked = true;
            this.checkBox_ShowLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ShowLine.Location = new System.Drawing.Point(257, 13);
            this.checkBox_ShowLine.Name = "checkBox_ShowLine";
            this.checkBox_ShowLine.Size = new System.Drawing.Size(116, 17);
            this.checkBox_ShowLine.TabIndex = 3;
            this.checkBox_ShowLine.Text = "Show line number?";
            this.checkBox_ShowLine.UseVisualStyleBackColor = true;
            // 
            // textBox_Code
            // 
            this.textBox_Code.Location = new System.Drawing.Point(18, 49);
            this.textBox_Code.Multiline = true;
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Code.Size = new System.Drawing.Size(661, 339);
            this.textBox_Code.TabIndex = 4;
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(535, 12);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(74, 23);
            this.button_Insert.TabIndex = 5;
            this.button_Insert.Text = "Insert";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(615, 12);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(64, 23);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Style:";
            // 
            // comboBox_Style
            // 
            this.comboBox_Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Style.FormattingEnabled = true;
            this.comboBox_Style.Location = new System.Drawing.Point(427, 15);
            this.comboBox_Style.Name = "comboBox_Style";
            this.comboBox_Style.Size = new System.Drawing.Size(102, 21);
            this.comboBox_Style.TabIndex = 8;
            // 
            // CodeInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 400);
            this.Controls.Add(this.comboBox_Style);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.checkBox_ShowLine);
            this.Controls.Add(this.comboBox_Language);
            this.Controls.Add(this.Language);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CodeInForm";
            this.Text = "CodeInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.ComboBox comboBox_Language;
        private System.Windows.Forms.CheckBox checkBox_ShowLine;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Style;
    }
}