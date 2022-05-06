
using MiniBank;

var account = new BankAccount ("Franck", 10000) ;
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with an initial deposit of {account.Balance} XAF ...");
// let's make a deposit of 15000
account.MakeDeposit(15000, DateTime.Now, "Savings");
Console.WriteLine(account.Balance);

// let's make a withdrawal of 5000
account.MakeWithDrawal(5000, DateTime.Now, "Bills");
Console.WriteLine(account.Balance);