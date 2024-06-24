namespace BankManagementSystem
{
    partial class AddClient
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
            this.txtxAddAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.txtAddAge = new System.Windows.Forms.TextBox();
            this.txtAddBalance = new System.Windows.Forms.TextBox();
            this.lblAddMenu = new System.Windows.Forms.Label();
            this.lblAddAccountNumber = new System.Windows.Forms.Label();
            this.lblAddFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtxAddAccountNumber
            // 
            this.txtxAddAccountNumber.Location = new System.Drawing.Point(176, 100);
            this.txtxAddAccountNumber.Name = "txtxAddAccountNumber";
            this.txtxAddAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtxAddAccountNumber.TabIndex = 0;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(176, 144);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtAddFirstName.TabIndex = 1;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(176, 187);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(100, 20);
            this.txtAddLastName.TabIndex = 2;
            // 
            // txtAddAge
            // 
            this.txtAddAge.Location = new System.Drawing.Point(176, 230);
            this.txtAddAge.Name = "txtAddAge";
            this.txtAddAge.Size = new System.Drawing.Size(100, 20);
            this.txtAddAge.TabIndex = 3;
            // 
            // txtAddBalance
            // 
            this.txtAddBalance.Location = new System.Drawing.Point(176, 274);
            this.txtAddBalance.Name = "txtAddBalance";
            this.txtAddBalance.Size = new System.Drawing.Size(100, 20);
            this.txtAddBalance.TabIndex = 4;
            // 
            // lblAddMenu
            // 
            this.lblAddMenu.AutoSize = true;
            this.lblAddMenu.Location = new System.Drawing.Point(241, 37);
            this.lblAddMenu.Name = "lblAddMenu";
            this.lblAddMenu.Size = new System.Drawing.Size(80, 13);
            this.lblAddMenu.TabIndex = 5;
            this.lblAddMenu.Text = "Add New Client";
            // 
            // lblAddAccountNumber
            // 
            this.lblAddAccountNumber.AutoSize = true;
            this.lblAddAccountNumber.Location = new System.Drawing.Point(41, 107);
            this.lblAddAccountNumber.Name = "lblAddAccountNumber";
            this.lblAddAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.lblAddAccountNumber.TabIndex = 6;
            this.lblAddAccountNumber.Text = "Account Number";
            // 
            // lblAddFirstName
            // 
            this.lblAddFirstName.AutoSize = true;
            this.lblAddFirstName.Location = new System.Drawing.Point(71, 151);
            this.lblAddFirstName.Name = "lblAddFirstName";
            this.lblAddFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblAddFirstName.TabIndex = 7;
            this.lblAddFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(70, 194);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(102, 237);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(82, 281);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.Text = "Balance";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save Client";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblAddFirstName);
            this.Controls.Add(this.lblAddAccountNumber);
            this.Controls.Add(this.lblAddMenu);
            this.Controls.Add(this.txtAddBalance);
            this.Controls.Add(this.txtAddAge);
            this.Controls.Add(this.txtAddLastName);
            this.Controls.Add(this.txtAddFirstName);
            this.Controls.Add(this.txtxAddAccountNumber);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtxAddAccountNumber;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.TextBox txtAddAge;
        private System.Windows.Forms.TextBox txtAddBalance;
        private System.Windows.Forms.Label lblAddMenu;
        private System.Windows.Forms.Label lblAddAccountNumber;
        private System.Windows.Forms.Label lblAddFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnSave;
    }
}