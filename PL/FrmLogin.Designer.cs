
namespace PL
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.userNoTxtBx = new System.Windows.Forms.TextBox();
            this.userNoLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxtBx = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNoTxtBx
            // 
            this.userNoTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNoTxtBx.Location = new System.Drawing.Point(177, 50);
            this.userNoTxtBx.Name = "userNoTxtBx";
            this.userNoTxtBx.Size = new System.Drawing.Size(140, 26);
            this.userNoTxtBx.TabIndex = 0;
            this.userNoTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNoTxtBx_KeyPress);
            // 
            // userNoLbl
            // 
            this.userNoLbl.AutoSize = true;
            this.userNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNoLbl.Location = new System.Drawing.Point(62, 53);
            this.userNoLbl.Name = "userNoLbl";
            this.userNoLbl.Size = new System.Drawing.Size(74, 20);
            this.userNoLbl.TabIndex = 5;
            this.userNoLbl.Text = "User No";
            this.userNoLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(66, 170);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 35);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(62, 109);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(86, 20);
            this.passwordLbl.TabIndex = 0;
            this.passwordLbl.Text = "Password";
            // 
            // passwordTxtBx
            // 
            this.passwordTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBx.Location = new System.Drawing.Point(177, 106);
            this.passwordTxtBx.Name = "passwordTxtBx";
            this.passwordTxtBx.Size = new System.Drawing.Size(140, 26);
            this.passwordTxtBx.TabIndex = 1;
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.Location = new System.Drawing.Point(195, 170);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(122, 35);
            this.enterBtn.TabIndex = 3;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 257);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordTxtBx);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.userNoLbl);
            this.Controls.Add(this.userNoTxtBx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNoTxtBx;
        private System.Windows.Forms.Label userNoLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxtBx;
        private System.Windows.Forms.Button enterBtn;
    }
}

