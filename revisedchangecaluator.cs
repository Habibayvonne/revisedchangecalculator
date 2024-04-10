// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//using static System.Console;
using static System.Convert;
using static SplashKitSDK.SplashKit;


const int NUM_MONEY_TYPES = 6;

const int THOUSAND = 1000;
const int TWO_FIFTY = 250;
const int TWO_DOLLARS = 200;
const int TWENTY= 20;
const int TEN = 10;
const int FIVE = 5;

string again = ""; // used to check if the user want to run again
string line;

do
{
    Write("Cost of item in dollars: ");
    line = ReadLine();
    while (!IsInteger(line))
    {
        WriteLine("Please enter a whole number.");
        Write("Cost of item in dollars: ");
        line = ReadLine();

    }
    int costOfItem = ToInt32(line);

    Write("Payment in dollarss: ");
    line = ReadLine();
    while (!IsInteger(line))
    {
        WriteLine("Please enter a whole number.");
        Write("Payment in dollarss: ");
        line = ReadLine();
    }

    int amountPaid = ToInt32(line);

    if (amountPaid >= costOfItem)
    {
        int changeValue = amountPaid - costOfItem;
        int toGive;

        Write("Change: ");

        int coinValue;
        string coinText;

        for(int i = 0; i < NUM_MONEY_TYPES; i++)
        {
            switch (i)
            {
                case 0:
                    coinValue = TWO_FIFTY;
                    coinText = "$250, ";
                    break;
                case 1:
                    coinValue = TWO_DOLLARS;
                    coinText = "$200, ";
                    break;
                case 2:
                    coinValue = THOUSAND;
                    coinText = "1000, ";
                    break;
                case 3:
                    coinValue = TWENTY;
                    coinText = "20, ";
                    break;
                case 4:
                    coinValue = TEN;
                    coinText = "10, ";
                    break;
                case 5:
                    coinValue = FIVE;
                    coinText = "5";
                    break;
                default:
                    coinValue = 1;
                    coinText = "ERROR";
                    break;
            }

            // Give Change
            toGive = changeValue / coinValue;
            changeValue = changeValue - toGive * coinValue;
            Write($"{toGive} x {coinText}");
        }

        WriteLine();
    }
    else
    {
        WriteLine("Insufficient payment");
    }

    Write("Run again: ");
    again = ReadLine();
} while ( again != "n" && again != "N");