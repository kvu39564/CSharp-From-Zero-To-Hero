using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            string highestBalanceHolder = "";
            decimal highestBalanceEver = 0.0m;

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var personalHighest = 0.0m;

                var personalInfo = peopleAndBalances[i];
                var arr = personalInfo.Split(", ");

                //get highest balance of person
                for(var j = 1; j < arr.Length; j++)
                {

                    decimal balance = 0.0m;

                    var isDecimal = decimal.TryParse(arr[j], out balance);

                    if(isDecimal)
                    {
                        personalHighest = (balance > personalHighest) ? balance : personalHighest;
                    }
                }

                //get highest balance of everyone and update name of highest
                if(personalHighest > highestBalanceEver)
                {
                    highestBalanceEver = personalHighest;
                    highestBalanceHolder = arr[0];
                }
            }

            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            return $"{highestBalanceHolder} had the most money ever. {highestBalanceEver:C0}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            string lossBalanceHolder = "";
            decimal biggestLossEver = 0.0m;

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var personalLoss = 0.0m;

                var personalInfo = peopleAndBalances[i];
                var arr = personalInfo.Split(", ");

                var lastBalance = 0.0m;

                //get biggest loss of person
                for (var j = 1; j < arr.Length; j++)
                {

                    decimal balance = 0.0m;

                    var isDecimal = decimal.TryParse(arr[j], out balance);

                    if (isDecimal)
                    {
                        //calculate loss from using previous balance
                        personalLoss = ((balance - lastBalance) < personalLoss) ? (balance - lastBalance) : personalLoss;
                    }
                }

                //get highest balance of everyone and update name of highest
                if (personalLoss < biggestLossEver)
                {
                    biggestLossEver = personalLoss;
                    lossBalanceHolder = arr[0];
                }
            }

            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            return $"{lossBalanceHolder} lost the most money. {biggestLossEver:C0}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            string richestPerson = "";
            decimal richestBalance = 0.0m;

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var balance = 0.0m;
                var personalInfo = peopleAndBalances[i];
                var arr = personalInfo.Split(", ");

                var isDecimal = decimal.TryParse(arr[arr.Length - 1], out balance);

                //get current balance and track person with highest balace
                if (isDecimal)
                {
                    if (balance > richestBalance)
                    {
                        richestBalance = balance;
                        richestPerson = arr[0];
                    }
                }
            }

            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            return $"{richestPerson} is the richest person. {richestBalance:C0}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            string poorestPerson = "";
            decimal poorestBalance = 0.0m;

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var balance = 0.0m;
                var personalInfo = peopleAndBalances[i];
                var arr = personalInfo.Split(", ");

                var isDecimal = decimal.TryParse(arr[arr.Length - 1], out balance);

                //get current balance and track person with highest balace
                if (isDecimal)
                {
                    if(i == 0)
                    {
                        poorestBalance = balance;
                        poorestPerson = arr[0];
                    }
                    else if (balance < poorestBalance)
                    {
                        poorestBalance = balance;
                        poorestPerson = arr[0];
                    }
                }
            }

            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            return $"{poorestPerson} has the least money. {poorestBalance:C0}.";
        }
    }
}
