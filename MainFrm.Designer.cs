namespace FortniteMacroEdit
{
    partial class MainFrm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMacroEdit = new System.Windows.Forms.Button();
            this.comboBoxKey = new System.Windows.Forms.ComboBox();
            this.editKeyLabel = new System.Windows.Forms.Label();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.delayLabel = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // buttonMacroEdit
            // 
            this.buttonMacroEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMacroEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(140)))), ((int)(((byte)(239)))));
            this.buttonMacroEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMacroEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMacroEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpProvider1.SetHelpString(this.buttonMacroEdit, "Enable/disable the macro edit.");
            this.buttonMacroEdit.Location = new System.Drawing.Point(54, 95);
            this.buttonMacroEdit.Name = "buttonMacroEdit";
            this.helpProvider1.SetShowHelp(this.buttonMacroEdit, true);
            this.buttonMacroEdit.Size = new System.Drawing.Size(75, 26);
            this.buttonMacroEdit.TabIndex = 0;
            this.buttonMacroEdit.Text = "Disabled";
            this.buttonMacroEdit.UseVisualStyleBackColor = false;
            this.buttonMacroEdit.Click += new System.EventHandler(this.ButtonMacroEdit_Click);
            // 
            // comboBoxKey
            // 
            this.comboBoxKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKey.FormattingEnabled = true;
            this.comboBoxKey.Location = new System.Drawing.Point(83, 22);
            this.comboBoxKey.Name = "comboBoxKey";
            this.comboBoxKey.Size = new System.Drawing.Size(84, 21);
            this.comboBoxKey.TabIndex = 1;
            this.comboBoxKey.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKey_SelectedIndexChanged);
            // 
            // editKeyLabel
            // 
            this.editKeyLabel.AutoSize = true;
            this.helpProvider1.SetHelpString(this.editKeyLabel, "Select your edit key in the list.");
            this.editKeyLabel.Location = new System.Drawing.Point(24, 25);
            this.editKeyLabel.Name = "editKeyLabel";
            this.helpProvider1.SetShowHelp(this.editKeyLabel, true);
            this.editKeyLabel.Size = new System.Drawing.Size(46, 13);
            this.editKeyLabel.TabIndex = 2;
            this.editKeyLabel.Text = "Edit Key";
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(83, 59);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(84, 20);
            this.textBoxDelay.TabIndex = 3;
            this.textBoxDelay.Text = "32";
            this.textBoxDelay.TextChanged += new System.EventHandler(this.TextBoxDelay_TextChanged);
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.helpProvider1.SetHelpString(this.delayLabel, "The time it takes between pressing the edit key and starting editing (in millisec" +
        "onds).");
            this.delayLabel.Location = new System.Drawing.Point(25, 62);
            this.delayLabel.Name = "delayLabel";
            this.helpProvider1.SetShowHelp(this.delayLabel, true);
            this.delayLabel.Size = new System.Drawing.Size(34, 13);
            this.delayLabel.TabIndex = 4;
            this.delayLabel.Text = "Delay";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(187, 133);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.textBoxDelay);
            this.Controls.Add(this.editKeyLabel);
            this.Controls.Add(this.comboBoxKey);
            this.Controls.Add(this.buttonMacroEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "FortniteMacroEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMacroEdit;
        private System.Windows.Forms.ComboBox comboBoxKey;
        private System.Windows.Forms.Label editKeyLabel;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

