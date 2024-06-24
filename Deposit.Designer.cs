namespace BankManagementSystem
{
    partial class Deposit
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtToAccount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblToAccount = new System.Windows.Forms.Label();
            this.lblAmmount = new System.Windows.Forms.Label();
            this.lblDeposita = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(127, 238);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtToAccount
            // 
            this.txtToAccount.Location = new System.Drawing.Point(127, 124);
            this.txtToAccount.Name = "txtToAccount";
            this.txtToAccount.Size = new System.Drawing.Size(100, 20);
            this.txtToAccount.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(127, 188);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // lblToAccount
            // 
            this.lblToAccount.AutoSize = true;
            this.lblToAccount.Location = new System.Drawing.Point(12, 127);
            this.lblToAccount.Name = "lblToAccount";
            this.lblToAccount.Size = new System.Drawing.Size(87, 13);
            this.lblToAccount.TabIndex = 3;
            this.lblToAccount.Text = "Account Number";
            // 
            // lblAmmount
            // 
            this.lblAmmount.AutoSize = true;
            this.lblAmmount.Location = new System.Drawing.Point(40, 195);
            this.lblAmmount.Name = "lblAmmount";
            this.lblAmmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmmount.TabIndex = 4;
            this.lblAmmount.Text = "Amount";
            // 
            // lblDeposita
            // 
            this.lblDeposita.AutoSize = true;
            this.lblDeposita.Location = new System.Drawing.Point(174, 92);
            this.lblDeposita.Name = "lblDeposita";
            this.lblDeposita.Size = new System.Drawing.Size(78, 13);
            this.lblDeposita.TabIndex = 5;
            this.lblDeposita.Text = "Deposit Money";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDeposita);
            this.Controls.Add(this.lblAmmount);
            this.Controls.Add(this.lblToAccount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtToAccount);
            this.Controls.Add(this.btnDeposit);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtToAccount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblToAccount;
        private System.Windows.Forms.Label lblAmmount;
        private System.Windows.Forms.Label lblDeposita;
    }
}