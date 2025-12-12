namespace Bank_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banl_account account = new Banl_account();
            //Banl_account account = new ();
            account.Owner = "John Doe";

                decimal bal =account.getBalance();
            Console.WriteLine(bal);

            Banl_account account2 = new Banl_account();
            account2.Owner = "Johne doe";



        }
    }
}
