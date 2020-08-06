using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            var result = BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);
            Console.WriteLine(result);

            // - FindPersonWithBiggestLoss
            result = BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances);
            Console.WriteLine(result);

            // - FindRichestPerson
            result = BalanceStats.FindRichestPerson(PeoplesBalances.Balances);
            Console.WriteLine(result);

            // - FindMostPoorPerson
            result = BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances);
            Console.WriteLine(result);
        }
    }
}
