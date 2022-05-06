
using MiniBank;

var account = new BankAccount ("Franck", 10000) ;
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with an initial deposit of {account.Balance} XAF ...");