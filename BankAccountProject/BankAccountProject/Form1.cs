// Keith Evans



using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace BankAccountProject {
    public partial class BankAccount : Form {
        public BankAccount() {
            InitializeComponent();
        }

        public string accountNumber;
        public decimal accountBalance;
        public string accountHistory;

        public bool checkInput;

        public enum accountStatus {

            OK, 
            Overdrawn, 
            InsufficientFunds,
            DepositTooLarge

        }

        private void BankAccount_Load(object sender, EventArgs e) {

            accountNumber = "000302019";
            accountBalance = 1362.59m;



            txtAccountNumber.Text = accountNumber;
            txtAccountBalance.Text = GetAccountBalance().ToString("C");



        }

        private void btnSubmit_Click(object sender, EventArgs e) {



            // Reset inputs
            txtTransactionStatus.Text = "";


            // Check for input error.
            if (txtTransactionAmount.Text == "") { // Check if the user input an amount for the transaction. 

                MessageBox.Show("You must input an amount for the transaction.");
                checkInput = false;
            }

            // Check for if user input a correct double format number into transaction amount. 
            if (decimal.TryParse(txtTransactionAmount.Text, out decimal transactionAmount)) {

                // User input a numeber correctly. 

            } else {

                MessageBox.Show("You must input a transaction amount in the format: XXX.XX");
                checkInput = false;
            }

            // Check if user failed the inputCheck. If so, do no calculations. 
            if (!checkInput) {
                
                // The user is making a deposit.
                if (radDeposit.Checked) {

                    switch (Deposit(transactionAmount)) {

                        case accountStatus.OK:
                            accountBalance += transactionAmount;
                            txtTransactionStatus.Text = "Transaction Successful.";
                            break;
                        case accountStatus.DepositTooLarge:
                            txtTransactionStatus.Text = "The transaction amount is too large and cannot be submitted.";
                            break;
                    }


                } else if (radWithdrawal.Checked) { // the user is making a withdrawal.
                    
                    switch (Withdrawal(transactionAmount)) {
                        case accountStatus.OK:
                            accountBalance -= transactionAmount;
                            txtTransactionStatus.Text = "Transaction Successful.";
                            break;
                        case accountStatus.InsufficientFunds:
                            txtTransactionStatus.Text = "Your account has insufficent funds for this transaction.";
                            break;
                        case accountStatus.Overdrawn:
                            txtTransactionStatus.Text = "Your account is overdrawn. Please make a deposit.";
                            accountBalance -= transactionAmount;
                            break;
                    }
                } else { // The user did not select Deposit or Withdrawal.

                    MessageBox.Show("Select a transaction type.", "Account Status");

                }

                // Update Account History
                    accountHistory = GetAccountBalance().ToString("C") + Environment.NewLine + accountHistory;



                // Reload our display.
                txtAccountBalance.Text = GetAccountBalance().ToString("C");



            } // checkInput





        } // Button Submit

        private decimal GetAccountBalance() {

            return accountBalance;
        }




        private accountStatus GetAccountStatus(decimal accountBalance) {

            if (accountBalance >= 0) {

                // Account is good.
                return accountStatus.OK;

            } else { 

                // The account needs a deposit.
                return accountStatus.InsufficientFunds;
                
            }

        }


        private accountStatus Deposit(decimal amountToDeposit) {

            // Determine the deposited amount and check if it is less than 10,000.
            if (amountToDeposit > 10000) {

                return accountStatus.DepositTooLarge;

            } else {

                return accountStatus.OK;
            } 
        }//Deposit


        private accountStatus Withdrawal(decimal amountToWithdrawal) {

            // If the transaction will put the amount under -100 or is already in the negative. 
            if ((GetAccountBalance() - amountToWithdrawal < (-100)) || GetAccountBalance() < 0) {

                return accountStatus.InsufficientFunds;

            // If the transaction will put the account between 0 and -100
            } else if ((GetAccountBalance() - amountToWithdrawal < 0) && (GetAccountBalance() - amountToWithdrawal > -100)) {

                return accountStatus.Overdrawn;

            // The account is positive.
            } else {

                return accountStatus.OK;
            }


        }



        private void btnGetHistory_Click(object sender, EventArgs e) {

            // Display the current account's history.
            txtAccountHistory.Text = accountHistory;

        }

        private void btnClose_Click(object sender, EventArgs e) {
            // close the program.

            this.Close();

        }

        private void btnGetStatus_Click(object sender, EventArgs e) {

            // Determine account status and display it.
            accountStatus accountStatus = GetAccountStatus(accountBalance);
            switch (accountStatus) {

                case accountStatus.OK:
                    MessageBox.Show("Your account is in good standing.", "Account Status");
                    break;
                case accountStatus.Overdrawn:
                    MessageBox.Show("Your account is overdrawn. Please make a deposit.", "Account Status");
                    break;
                case accountStatus.InsufficientFunds:
                    MessageBox.Show("Your account has insufficient funds for this transaction.", "Account Status"); ;
                    break;
                case accountStatus.DepositTooLarge:
                    MessageBox.Show("Your account is overdrawn. Please make a deposit.", "Account Status");
                    break;
            }


        }
    }
}
