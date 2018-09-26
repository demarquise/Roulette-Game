using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rorlette
{
    public class Bets 
    {
        static public int[] numbers = { 0, 00, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 16, 17, 18, 19,
                                20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        public static string[] colors = { "red", "black" };
        public static int chips = 10000;
        public static string[] EO = { "even", "odd" };
        public static string[] COL = { "first", "second", "third" };

        public void betmethod()
        {
            
                Console.WriteLine("What bet would you like to place");
                Console.WriteLine("                                                                          Chips-> " + chips);
                Console.WriteLine("A| Numbers: the number of the bin            ");
                Console.WriteLine("B| Evens/Odds: even or odd numbers           ");
                Console.WriteLine("C| Reds/Blacks: red or black colored numbers ");
                Console.WriteLine("D| Lows/Highs: low (1 – 18) or high (19 – 38) numbers");
                Console.WriteLine("E| Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36");
                Console.WriteLine("F| Columns: first, second, or third columns");
                Console.WriteLine("G| Street: rows, e.g., 1/2/3 or 22/23/24");
                Console.WriteLine("H| 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26");
                Console.WriteLine("I| Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36");
                Console.WriteLine("J| Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27");
                //make it so bet they choose they can put money in 
                //implement math to subtract if they loose an add if they win or multiply 
                //try puuting a for loop to generate an random number for between the arrays in the if else
                Console.WriteLine("");
                Console.Write("What bet would you like to make ????? : ");
           

                string choice = Console.ReadLine();

                if (choice.ToLower() == "a")
                {
                    Console.WriteLine("You choose Numbers: the number of the bin ");
                    Console.WriteLine("");
                    Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    chips = chips - answer;
                    Console.WriteLine("");
                    Console.Write("Choose a number between 00-36 : ");
                    int pick = Convert.ToInt32(Console.ReadLine());
                    Random AA = new Random();

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("The number you landed on is " + numbers[AA.Next(numbers.Length)]);
                    if (pick == numbers[AA.Next(numbers.Length)])
                    {
                        answer = answer * 2;
                        chips = answer + chips;
                        Console.WriteLine("Congrats you Won you have a total of " + chips + "now");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    else
                    {
                        Console.WriteLine("sorry you didnt win you have " + chips + " chips left");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    
                }
                else if (choice.ToLower() == "b")
                {
                    Console.WriteLine("You choose Evens/Odds: even or odd numbers");
                    Console.WriteLine("");
                    Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    chips = chips - answer;
                    Console.WriteLine("");
                    Console.Write("choose even or odd : ");
                    string Twopicked = Console.ReadLine();
                    Random BB = new Random();

                    Console.WriteLine("you landed on " + EO[BB.Next(EO.Length)]);
                    Console.WriteLine("");
                    if (Twopicked == EO[BB.Next(EO.Length)])  //need to make it accurate when picking a strig array
                    {                                           // when i enter a sring it should be accrate to my answer
                        answer = answer * 2;
                        chips = answer + chips;
                        Console.WriteLine("Congrats you Won you have a total of " + chips + " now ");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    else
                    {
                        Console.WriteLine("sorry you didnt win you have " + chips + " chips left");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    
                }
                else if (choice.ToLower() == "c")
                {
                    Console.WriteLine(" You choose  Reds/Blacks: red or black colored numbers ");
                    Console.WriteLine("");
                    Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    chips = chips - answer;
                    Console.WriteLine("");
                    Console.Write("choose Red or Black : ");
                    string Twopicked = Console.ReadLine();
                    Random CC = new Random();

                    Console.WriteLine("you landed on " + colors[CC.Next(colors.Length)]);
                    Console.WriteLine("");
                    if (Twopicked.ToLower() == colors[CC.Next(colors.Length)])
                    {
                        answer = answer * 2;
                        chips = answer + chips;
                        Console.WriteLine("Congrats you Won you have a total of " + chips + " now ");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    else
                    {
                        Console.WriteLine("sorry you didnt win you have " + chips + " chips left");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    
                }
                else if (choice.ToLower() == "d")
                {
                    Console.WriteLine("You choose Lows/Highs: low (1 – 18) or high (19 – 38) numbers");
                    Console.WriteLine("");
                    Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    chips = chips - answer;
                    Console.WriteLine("");
                    Console.Write(" Choose highs or lows  : ");
                    string Twopicked = Console.ReadLine();
                    Random DD = new Random();
                    Console.WriteLine("you landed on " + numbers[DD.Next(numbers.Length)]);

                    if ((numbers[DD.Next(numbers.Length)] >= 1 && numbers[DD.Next(numbers.Length)] <= 18 && Twopicked == "lows")
                    || (numbers[DD.Next(numbers.Length)] >= 19 && numbers[DD.Next(numbers.Length)] <= 36 && Twopicked == "highs"))  //make it so i can do 1 threw 18
                    {

                        answer = answer * 2;
                        chips = answer + chips;
                        Console.WriteLine("You won " + chips + " chips");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }

                    else
                    {
                        Console.WriteLine("you lost you have " + chips + " chips left");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    
                }
                else if (choice.ToLower() == "e")
                {
                    Console.WriteLine("Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36");
                    Console.WriteLine("");
                    Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    chips = chips - answer;
                    Console.WriteLine("");
                    Console.Write(" Choose  a row |first|second|third  : ");
                    string Twopicked = Console.ReadLine();
                    Random EE = new Random();
                    Console.WriteLine("you landed on " + numbers[EE.Next(numbers.Length)]);
                    if (numbers[EE.Next(numbers.Length)] >= 1 && numbers[EE.Next(numbers.Length)] <= 12 && Twopicked.ToLower() == "first" ||
                        numbers[EE.Next(numbers.Length)] >= 13 && numbers[EE.Next(numbers.Length)] <= 24 && Twopicked.ToLower() == "second" ||
                        numbers[EE.Next(numbers.Length)] >= 25 && numbers[EE.Next(numbers.Length)] <= 36 && Twopicked.ToLower() == "third")
                    {

                        answer = answer * 2;
                        chips = answer + chips;
                        Console.WriteLine("You won " + chips + " chips");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");

                    }
                    else
                    {
                        Console.WriteLine("you lost you have " + chips + "chips left");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                  
                }
                else if (choice.ToLower() == "f")
                {
                    Console.WriteLine("You choose Columns: first, second, or third columns");
                    Console.WriteLine("");
                    Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    chips = chips - answer;
                    Console.WriteLine("");
                    Console.Write(" Choose  a column |first|second|third  : ");
                    string Twopicked = Console.ReadLine();
                    Random FF = new Random();
                    Console.WriteLine("You landed on " + COL[FF.Next(COL.Length)]);

                    if (Twopicked == COL[FF.Next(COL.Length)])
                    {

                        answer = answer * 2;
                        chips = answer + chips;
                        Console.WriteLine("You won " + chips + " chips");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    else
                    {
                        Console.WriteLine("you lost you have " + chips + "chips left");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                   
                }
                else if (choice.ToLower() == "g")
                {
                    Console.WriteLine("You choose Street: rows, e.g., 1/2/3 or 22/23/24 ");
                    Console.WriteLine("");
                    Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    chips = chips - answer;
                    Console.WriteLine("");
                    Console.Write("Choose a row 1/2/3|a| or 22/23/24|b| type a or b : ");
                    string Twopicked = Console.ReadLine();
                    Random GG = new Random();
                    Console.WriteLine("You landed on " + numbers[GG.Next(numbers.Length)]);

                    if ((Twopicked.ToLower() == "a" && numbers[GG.Next(numbers.Length)] <= 3) || (Twopicked.ToLower() == "b" &&
                        numbers[GG.Next(numbers.Length)] >= 22 && numbers[GG.Next(numbers.Length)] <= 24))
                    {
                        answer = answer * 2;
                        chips = answer + chips;
                        Console.WriteLine("You won " + chips + " chips ");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    else
                    {
                        Console.WriteLine("you lost you have " + chips + " chips left ");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    
                }
                else if (choice.ToLower() == "h")
                {
                    Console.WriteLine("You choose 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26 ");
                    Console.WriteLine("");
                    Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    chips = chips - answer;
                    Console.WriteLine("");
                    Console.Write("Choose a row 1/2/3/4/5/6|a| or 22/23/24/25/26/27|b| type a or b : ");
                    string Twopicked = Console.ReadLine();
                    Random HH = new Random();
                    Console.WriteLine("You landed on " + numbers[HH.Next(numbers.Length)]);

                    if ((Twopicked.ToLower() == "a" && numbers[HH.Next(numbers.Length)] <= 6) || (Twopicked.ToLower() == "b" &&
                        numbers[HH.Next(numbers.Length)] >= 22 && numbers[HH.Next(numbers.Length)] <= 26))
                    {
                        answer = answer * 2;
                        chips = answer + chips;
                        Console.WriteLine("You won " + chips + " chips ");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    else
                    {
                        Console.WriteLine("you lost you have " + chips + " chips left ");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    
                }
                else if (choice.ToLower() == "i")
                {
                    Console.WriteLine("You choose Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36 ");
                    Console.WriteLine("");
                    Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    chips = chips - answer;
                    Console.WriteLine("");
                    Console.Write("Choose a edge  1/2|a| or 11/14|b| or 35/36|c| type a or b or c : ");
                    string Twopicked = Console.ReadLine();
                    Random II = new Random();
                    Console.WriteLine("You landed on " + numbers[II.Next(numbers.Length)]);

                    if ((Twopicked.ToLower() == "a" && numbers[II.Next(numbers.Length)] <= 2) || (Twopicked.ToLower() == "b" &&
                        numbers[II.Next(numbers.Length)] == 11 || numbers[II.Next(numbers.Length)] == 14) || (Twopicked.ToLower() == "c"
                        && numbers[II.Next(numbers.Length)] == 35 || numbers[II.Next(numbers.Length)] == 36))
                    {
                        answer = answer * 2;
                        chips = answer + chips;
                        Console.WriteLine("You won " + chips + " chips ");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    else
                    {
                        Console.WriteLine("you lost you have " + chips + " chips left ");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                   
                }
                else if (choice.ToLower() == "j")
                {
                    Console.WriteLine("You choose Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27");
                    Console.WriteLine("");
                    Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    chips = chips - answer;
                    Console.WriteLine("");
                    Console.Write("Choose a intersection  1/2,4,5|a| or 23/24/26/27 type a or b  : ");
                    string Twopicked = Console.ReadLine();
                    Random JJ = new Random();
                    Console.WriteLine("You landed on " + numbers[JJ.Next(numbers.Length)]);

                    if ((Twopicked.ToLower() == "a" && numbers[JJ.Next(numbers.Length)] <= 5) || (Twopicked.ToLower() == "b" &&
                        numbers[JJ.Next(numbers.Length)] == 23 || numbers[JJ.Next(numbers.Length)] == 24 || numbers[JJ.Next(numbers.Length)] == 26
                        || numbers[JJ.Next(numbers.Length)] == 27))
                    {
                        answer = answer * 2;
                        chips = answer + chips;
                        Console.WriteLine("You won " + chips + " chips ");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    else
                    {
                        Console.WriteLine("you lost you have " + chips + " chips left ");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter twice to Continue");
                    }
                    
                }
                else
                {
                    Console.WriteLine("choose a,b,c,d,e,f,g,h,i, or j");
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter twice to Continue");
                }
                Console.ReadLine();
               
           
            
        }
    }
}
