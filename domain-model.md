|   | Class            | Method                                     | Scenario                                                                  |
|---|------------------|--------------------------------------------|---------------------------------------------------------------------------|
|   | Customer         | CreateAccount(string type)                 | Customer creates an account based on type                                 |
|   | Customer         | DepositFunds(int funds)                    | Customer deposits funds                                                   |
|   | Customer         | WithdrawFunds(int funds)                   | Customer withdraws funds                                                  |
|   | Overdraft        | CreateOverdraftRequest()                   | Create an overdraft request                                               |
|   | Manager          | ProcessOverdraftRequest(Overdraft request) | Accept or reject overdraft request from customer                          |
|   | abstract Account | GenerateBankStatement()                    | Generates the bank statement for the account                              |
|   | abstract Account | GenberateBankStatementFromHistory()        | Generates the bank statement for the account based on transaction history |
|   | abstract Account | DepositFunds(int funds)                    |                                                                           |
|   | abstract Account | WithdrawFunds(int funds)                   |                                                                           |
|   | CurrentAccount   |                                            |                                                                           |
|   | SavingsAccount   |                                            |                                                                           |