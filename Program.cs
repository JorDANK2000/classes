//Bank Account Tutorial from Microsoft completed by Jordan King on 06-07-2023
using classes;
internal class Program
{
    private static void Main(string[] args)
    {
        //Create a new account
        var account = new BankAccount("Jordan", 1000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        //Testing MakeWithdrawl and MakeDesposit methods.
        account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
        Console.WriteLine(account.Balance);
        account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
        Console.WriteLine(account.Balance);
        //Test for a negative balance
        /*try
        {
            account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraft");
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Exception caught trying to overdraft");
            Console.WriteLine(e.ToString());
        }
        //Test that initial balance must be positive
        BankAccount invalidAccount;
        try
        {
            invalidAccount = new BankAccount("invalid", -55);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Exception caught creating account with negative balance");
            Console.WriteLine(e.ToString());
            return;
        }*/
        //Test getAccountHistroy
        Console.WriteLine(account.GetAccountHistory());
    }
}