namespace BankAccountProject {
    partial class BankAccount {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblAccountNumber = new Label();
            txtAccountNumber = new TextBox();
            lblAccountBalance = new Label();
            txtAccountBalance = new TextBox();
            grpTransactionType = new GroupBox();
            txtTransactionStatus = new TextBox();
            lblTransactionStatus = new Label();
            btnSubmit = new Button();
            txtTransactionAmount = new TextBox();
            lblTransactionAmount = new Label();
            radWithdrawal = new RadioButton();
            radDeposit = new RadioButton();
            panel1 = new Panel();
            btnClose = new Button();
            btnGetStatus = new Button();
            btnGetHistory = new Button();
            lblAccountHistory = new Label();
            txtAccountHistory = new TextBox();
            grpTransactionType.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Location = new Point(28, 40);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(102, 15);
            lblAccountNumber.TabIndex = 0;
            lblAccountNumber.Text = "Account Number:";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(162, 37);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.ReadOnly = true;
            txtAccountNumber.Size = new Size(176, 23);
            txtAccountNumber.TabIndex = 1;
            txtAccountNumber.TabStop = false;
            // 
            // lblAccountBalance
            // 
            lblAccountBalance.AutoSize = true;
            lblAccountBalance.Location = new Point(368, 40);
            lblAccountBalance.Name = "lblAccountBalance";
            lblAccountBalance.Size = new Size(102, 15);
            lblAccountBalance.TabIndex = 2;
            lblAccountBalance.Text = "Account Balance: ";
            // 
            // txtAccountBalance
            // 
            txtAccountBalance.Location = new Point(485, 37);
            txtAccountBalance.Name = "txtAccountBalance";
            txtAccountBalance.ReadOnly = true;
            txtAccountBalance.Size = new Size(186, 23);
            txtAccountBalance.TabIndex = 3;
            txtAccountBalance.TabStop = false;
            // 
            // grpTransactionType
            // 
            grpTransactionType.Controls.Add(txtTransactionStatus);
            grpTransactionType.Controls.Add(lblTransactionStatus);
            grpTransactionType.Controls.Add(btnSubmit);
            grpTransactionType.Controls.Add(txtTransactionAmount);
            grpTransactionType.Controls.Add(lblTransactionAmount);
            grpTransactionType.Controls.Add(radWithdrawal);
            grpTransactionType.Controls.Add(radDeposit);
            grpTransactionType.Location = new Point(28, 83);
            grpTransactionType.Name = "grpTransactionType";
            grpTransactionType.Size = new Size(672, 292);
            grpTransactionType.TabIndex = 4;
            grpTransactionType.TabStop = false;
            grpTransactionType.Text = "Transaction Type";
            // 
            // txtTransactionStatus
            // 
            txtTransactionStatus.Location = new Point(135, 256);
            txtTransactionStatus.Name = "txtTransactionStatus";
            txtTransactionStatus.ReadOnly = true;
            txtTransactionStatus.Size = new Size(522, 23);
            txtTransactionStatus.TabIndex = 10;
            txtTransactionStatus.TabStop = false;
            // 
            // lblTransactionStatus
            // 
            lblTransactionStatus.AutoSize = true;
            lblTransactionStatus.Location = new Point(21, 259);
            lblTransactionStatus.Name = "lblTransactionStatus";
            lblTransactionStatus.Size = new Size(108, 15);
            lblTransactionStatus.TabIndex = 9;
            lblTransactionStatus.Text = "Transaction Status: ";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(21, 161);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 3;
            btnSubmit.TabStop = false;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtTransactionAmount
            // 
            txtTransactionAmount.Location = new Point(147, 115);
            txtTransactionAmount.Name = "txtTransactionAmount";
            txtTransactionAmount.Size = new Size(141, 23);
            txtTransactionAmount.TabIndex = 8;
            // 
            // lblTransactionAmount
            // 
            lblTransactionAmount.AutoSize = true;
            lblTransactionAmount.Location = new Point(21, 118);
            lblTransactionAmount.Name = "lblTransactionAmount";
            lblTransactionAmount.Size = new Size(120, 15);
            lblTransactionAmount.TabIndex = 8;
            lblTransactionAmount.Text = "Transaction Amount: ";
            // 
            // radWithdrawal
            // 
            radWithdrawal.AutoSize = true;
            radWithdrawal.Location = new Point(21, 70);
            radWithdrawal.Name = "radWithdrawal";
            radWithdrawal.Size = new Size(85, 19);
            radWithdrawal.TabIndex = 1;
            radWithdrawal.Text = "Withdrawal";
            radWithdrawal.UseVisualStyleBackColor = true;
            // 
            // radDeposit
            // 
            radDeposit.AutoSize = true;
            radDeposit.Location = new Point(21, 36);
            radDeposit.Name = "radDeposit";
            radDeposit.Size = new Size(65, 19);
            radDeposit.TabIndex = 0;
            radDeposit.Text = "Deposit";
            radDeposit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnGetStatus);
            panel1.Controls.Add(btnGetHistory);
            panel1.Location = new Point(12, 394);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 52);
            panel1.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(799, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnGetStatus
            // 
            btnGetStatus.Location = new Point(117, 12);
            btnGetStatus.Name = "btnGetStatus";
            btnGetStatus.Size = new Size(75, 23);
            btnGetStatus.TabIndex = 1;
            btnGetStatus.TabStop = false;
            btnGetStatus.Text = "Get Status";
            btnGetStatus.UseVisualStyleBackColor = true;
            btnGetStatus.Click += btnGetStatus_Click;
            // 
            // btnGetHistory
            // 
            btnGetHistory.Location = new Point(16, 12);
            btnGetHistory.Name = "btnGetHistory";
            btnGetHistory.Size = new Size(75, 23);
            btnGetHistory.TabIndex = 0;
            btnGetHistory.TabStop = false;
            btnGetHistory.Text = "Get History";
            btnGetHistory.UseVisualStyleBackColor = true;
            btnGetHistory.Click += btnGetHistory_Click;
            // 
            // lblAccountHistory
            // 
            lblAccountHistory.AutoSize = true;
            lblAccountHistory.Location = new Point(706, 65);
            lblAccountHistory.Name = "lblAccountHistory";
            lblAccountHistory.Size = new Size(99, 15);
            lblAccountHistory.TabIndex = 6;
            lblAccountHistory.Text = "Account History: ";
            // 
            // txtAccountHistory
            // 
            txtAccountHistory.Location = new Point(706, 83);
            txtAccountHistory.Multiline = true;
            txtAccountHistory.Name = "txtAccountHistory";
            txtAccountHistory.ScrollBars = ScrollBars.Vertical;
            txtAccountHistory.Size = new Size(196, 292);
            txtAccountHistory.TabIndex = 7;
            txtAccountHistory.TabStop = false;
            // 
            // BankAccount
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 450);
            Controls.Add(txtAccountHistory);
            Controls.Add(lblAccountHistory);
            Controls.Add(panel1);
            Controls.Add(grpTransactionType);
            Controls.Add(txtAccountBalance);
            Controls.Add(lblAccountBalance);
            Controls.Add(txtAccountNumber);
            Controls.Add(lblAccountNumber);
            Name = "BankAccount";
            Text = "Bank Account Manager";
            Load += BankAccount_Load;
            grpTransactionType.ResumeLayout(false);
            grpTransactionType.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountNumber;
        private TextBox txtAccountNumber;
        private Label lblAccountBalance;
        private TextBox txtAccountBalance;
        private GroupBox grpTransactionType;
        private Panel panel1;
        private Button btnClose;
        private Button btnGetStatus;
        private Button btnGetHistory;
        private Label lblAccountHistory;
        private TextBox txtTransactionStatus;
        private Label lblTransactionStatus;
        private Button btnSubmit;
        private TextBox txtTransactionAmount;
        private Label lblTransactionAmount;
        private RadioButton radWithdrawal;
        private RadioButton radDeposit;
        private TextBox txtAccountHistory;
    }
}
