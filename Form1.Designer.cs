namespace BankManagementSystem
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnClientSearch = new System.Windows.Forms.Button();
            this.btnDebitBalances = new System.Windows.Forms.Button();
            this.btnCreditBalance = new System.Windows.Forms.Button();
            this.btnZeroBalances = new System.Windows.Forms.Button();
            this.btnMakeDeposit = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.dgvClinets = new System.Windows.Forms.DataGridView();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClinets)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnClientSearch
            // 
            this.btnClientSearch.Location = new System.Drawing.Point(12, 386);
            this.btnClientSearch.Name = "btnClientSearch";
            this.btnClientSearch.Size = new System.Drawing.Size(113, 23);
            this.btnClientSearch.TabIndex = 1;
            this.btnClientSearch.Text = "Search Client";
            this.btnClientSearch.UseVisualStyleBackColor = true;
            this.btnClientSearch.Click += new System.EventHandler(this.btnClientSearch_Click);
            // 
            // btnDebitBalances
            // 
            this.btnDebitBalances.Location = new System.Drawing.Point(151, 386);
            this.btnDebitBalances.Name = "btnDebitBalances";
            this.btnDebitBalances.Size = new System.Drawing.Size(113, 23);
            this.btnDebitBalances.TabIndex = 2;
            this.btnDebitBalances.Text = "Debit Balances";
            this.btnDebitBalances.UseVisualStyleBackColor = true;
            // 
            // btnCreditBalance
            // 
            this.btnCreditBalance.Location = new System.Drawing.Point(151, 415);
            this.btnCreditBalance.Name = "btnCreditBalance";
            this.btnCreditBalance.Size = new System.Drawing.Size(113, 23);
            this.btnCreditBalance.TabIndex = 3;
            this.btnCreditBalance.Text = "Credit Balances";
            this.btnCreditBalance.UseVisualStyleBackColor = true;
            // 
            // btnZeroBalances
            // 
            this.btnZeroBalances.Location = new System.Drawing.Point(270, 415);
            this.btnZeroBalances.Name = "btnZeroBalances";
            this.btnZeroBalances.Size = new System.Drawing.Size(113, 23);
            this.btnZeroBalances.TabIndex = 4;
            this.btnZeroBalances.Text = "Zero Balances";
            this.btnZeroBalances.UseVisualStyleBackColor = true;
            // 
            // btnMakeDeposit
            // 
            this.btnMakeDeposit.Location = new System.Drawing.Point(642, 386);
            this.btnMakeDeposit.Name = "btnMakeDeposit";
            this.btnMakeDeposit.Size = new System.Drawing.Size(113, 23);
            this.btnMakeDeposit.TabIndex = 5;
            this.btnMakeDeposit.Text = "Make Deposit";
            this.btnMakeDeposit.UseVisualStyleBackColor = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(12, 415);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(113, 23);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // dgvClinets
            // 
            this.dgvClinets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClinets.Location = new System.Drawing.Point(371, 27);
            this.dgvClinets.Name = "dgvClinets";
            this.dgvClinets.Size = new System.Drawing.Size(417, 167);
            this.dgvClinets.TabIndex = 7;
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(12, 27);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(191, 277);
            this.lstNames.TabIndex = 8;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(414, 222);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(642, 284);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(642, 222);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(414, 284);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 12;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(642, 325);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 13;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(323, 291);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(549, 225);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(581, 287);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 16;
            this.lblAge.Text = "Age:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(293, 222);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(90, 13);
            this.lblAccountNumber.TabIndex = 17;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(518, 332);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(92, 13);
            this.lblAccountBalance.TabIndex = 18;
            this.lblAccountBalance.Text = "Account Balance:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAccountBalance);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.dgvClinets);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnMakeDeposit);
            this.Controls.Add(this.btnZeroBalances);
            this.Controls.Add(this.btnCreditBalance);
            this.Controls.Add(this.btnDebitBalances);
            this.Controls.Add(this.btnClientSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClinets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnClientSearch;
        private System.Windows.Forms.Button btnDebitBalances;
        private System.Windows.Forms.Button btnCreditBalance;
        private System.Windows.Forms.Button btnZeroBalances;
        private System.Windows.Forms.Button btnMakeDeposit;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.DataGridView dgvClinets;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountBalance;
    }
}

