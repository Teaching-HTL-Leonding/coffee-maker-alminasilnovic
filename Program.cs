//givenmoney - moneyneed = restmoney, if rest money smaller than 0 then it does not have enough credit
//Mindestanforderung
//Beautify the output of your program (e.g. with emojis, colors, etc.)
//Check if the amount of money the user entered is a multiple of 0.5€. If not, print an error message and ask again.
//End the product preparation loop automatically if the money left is lower than the cheapest product (tea).

Console.OutputEncoding = System.Text.Encoding.Default;
double moneyneed = 0;
double moneygiven;
double restmoney = 0;
const double TEA = 1.5;
const double CAPPUCCINO = 3.5;
const double CACAO = 2.5;
const double COIN1 = 1;
const double COIN2 = 2;
const double COIN05 = 0.5;
double input;
double amountofcoins2;
double amountofcoins1;
double amountofcoins05;

do
{
    Console.ForegroundColor = ConsoleColor.Blue;
    System.Console.Write("Please enter the amount of money 💵 (multipiles of 0.5): ");
    moneygiven = double.Parse(Console.ReadLine()!);
    Console.ResetColor();
    if (moneygiven % 0.5 != 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("Wrong Input.");
        Console.ResetColor();
    }
}
while (moneygiven % 0.5 != 0);

do
{
    restmoney = 0;
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkRed;
    System.Console.WriteLine("1) Cappuccino ☕(3.5€), 2) Tea 🍵(1.5€), 3) Cacao 🍫(2.5€), 4) Nothing else");
    input = double.Parse(Console.ReadLine()!);
    Console.ResetColor();
    switch (input)
    {
        case 1:
            moneyneed += CAPPUCCINO;
            break;
        case 2:
            moneyneed += TEA;
            break;
        case 3:
            moneyneed += CACAO;
            break;
    }
    restmoney += moneygiven - moneyneed;
    if (restmoney < 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Sorry, you do not have enough credit left 🙁");
        Console.ResetColor();
        moneyneed = 0;
    }

}
while (input != 4 && restmoney >= TEA);

Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("You get " + restmoney + "$ back 🎉");
Console.ResetColor();
while (restmoney > 0)
{
    amountofcoins2 = Math.Floor(restmoney / 2);
    restmoney -= (amountofcoins2 * 2);
    if (amountofcoins2 > 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("You get " + amountofcoins2 + "x" + COIN2 + " pieces 🪙");
        Console.ResetColor();
    }
    amountofcoins1 = Math.Floor(restmoney);
    restmoney -= (amountofcoins1);
    if (amountofcoins1 > 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("You get " + amountofcoins1 + "x" + COIN1 + " pieces 🪙");
        Console.ResetColor();
    }
    amountofcoins05 = Math.Floor(restmoney / 0.5);
    restmoney -= (amountofcoins05 * 0.5);
    if (amountofcoins05 > 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("You get " + amountofcoins05 + "x" + COIN05 + " pieces 🪙");
        Console.ResetColor();
    }
}

Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine("Press any key to exit");
Console.ResetColor();
Console.ReadKey();
Console.Clear();