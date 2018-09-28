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
        public static   Random AA = new Random();
        
        public void betmethod()

        {

            Console.WriteLine("What bet would you like to place");
            Console.WriteLine("                                                                          Chips-> " + chips);
            Console.WriteLine("A| Numbers: the number of the bin  00--36          ");
            Console.WriteLine("");
            Console.WriteLine("B| Evens/Odds: even or odd numbers           ");
            Console.WriteLine("");
            Console.WriteLine("C| Reds/Blacks: red or black colored numbers ");
            Console.WriteLine("");
            Console.WriteLine("D| Lows/Highs: low (1 – 18) or high (19 – 38) numbers");
            Console.WriteLine("");
            Console.WriteLine("E| Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36");
            Console.WriteLine("");
            Console.WriteLine("F| Columns: first, second, or third columns");
            Console.WriteLine("");
            Console.WriteLine("G| Street: rows,  1/2/3 or 22/23/24");
            Console.WriteLine("");
            Console.WriteLine("H| 6 Numbers: double rows,  1/2/3/4/5/6 or 22/23/24/25/26/26");
            Console.WriteLine("");
            Console.WriteLine("I| Split: at the edge of any two contiguous numbers,  1/2, 11/14, and 35/36");
            Console.WriteLine("");
            Console.WriteLine("J| Corner: at the intersection of any four contiguous numbers, 1/2/4/5, or 23/24/26/27");
            //make it so bet they choose they can put money in 
            //implement math to subtract if they loose an add if they win or multiply 
            //try puuting a for loop to generate an random number for between the arrays in the if else
            Console.WriteLine("");
            Console.Write("What bet would you like to make ????? : ");


            string choice = Console.ReadLine();

            if (choice.ToLower() == "a")
            {
                Console.WriteLine("You choose Numbers: the number of the bin | chances of winning is 2.63%   Payout is * 35");

                Console.WriteLine("");
                Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                int answer; 
                while (!Int32.TryParse(Console.ReadLine(),out answer))
                {
                    Console.Write("Enter a number lesser or equal to your chips :");
                    Console.WriteLine("");
                }
                
                chips = chips - answer;
                Console.WriteLine("");
                Console.Write("Choose a number between 00-36 : ");
                int pick = Convert.ToInt32(Console.ReadLine());

                int pick2 = numbers[AA.Next(numbers.Length)];


                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You landed on " + pick2 + " " + colors[AA.Next(colors.Length)]);
                if (pick2 == pick)
                {
                    answer = answer * 35;
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
                Console.WriteLine("You choose Evens/Odds: even or odd numbers | the chances of winning are  47.4%  Payout is * 2");
                Console.WriteLine("");
                Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                int answer;
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                {
                    Console.Write("Enter a number lesser or equal to your chips :");
                    Console.WriteLine("");
                }
                chips = chips - answer;
                Console.WriteLine("");
                Console.Write("choose even or odd : ");
                Random AA = new Random();

                string Twopicked = Console.ReadLine();

                string nextPick = EO[AA.Next(EO.Length)];

                Console.WriteLine("you landed on " + nextPick);
                Console.WriteLine("");
                if (nextPick == Twopicked)  //need to make it accurate when picking a strig array
                {                                                          // when i enter a sring it should be accrate to my answer
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
                Console.WriteLine(" You choose  Reds/Blacks: red or black colored numbers | the chances of winning are 47.4%  Payout is * 2");
                Console.WriteLine("");
                Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                int answer;
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                {
                    Console.Write("Enter a number lesser or equal to your chips :");
                    Console.WriteLine("");
                }
                chips = chips - answer;
                Console.WriteLine("");
                Console.Write("choose Red or Black : ");
                string Twopicked = Console.ReadLine();
                
                
                string nextpick = colors[AA.Next(colors.Length)];

                Console.WriteLine("you landed on " + numbers[AA.Next(numbers.Length)] + " " + nextpick );
                Console.WriteLine("");
                if (Twopicked == nextpick)
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
                Console.WriteLine("You choose Lows/Highs: low (1 – 18) or high (19 – 38) numbers | chances of winning are 47.4%  Payout is * 2");
                Console.WriteLine("");
                Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                int answer;
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                {
                    Console.Write("Enter a number lesser or equal to your chips :");
                    Console.WriteLine("");
                }
                chips = chips - answer;
                Console.WriteLine("");
                Console.Write(" Choose highs or lows  : ");
                string Twopicked = Console.ReadLine();
                Random AA = new Random();
                int nextpick = numbers[AA.Next(numbers.Length)];
                Console.WriteLine("you landed on " + nextpick + " " + colors[AA.Next(colors.Length)]);

                if ((nextpick >= 1 && nextpick <= 18 && Twopicked == "lows")
                || (nextpick >= 19 && nextpick <= 36 && Twopicked == "highs"))  //make it so i can do 1 threw 18
                {

                    answer = answer * 2;
                    chips = answer + chips;
                    Console.WriteLine("You won " + answer + " chips");
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
                Console.WriteLine(" You choose : Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36 | chances of winning are 31.6%  Payout is * 3 ");
                Console.WriteLine("");
                Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                int answer;
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                {
                    Console.Write("Enter a number lesser or equal to your chips :");
                    Console.WriteLine("");
                }
                chips = chips - answer;
                Console.WriteLine("");
                Console.Write(" Choose  a row |first|second|third  : ");
                string Twopicked = Console.ReadLine();
                Random AA = new Random();
                int nextpick = numbers[AA.Next(numbers.Length)];
                Console.WriteLine("you landed on " + nextpick + " " + colors[AA.Next(colors.Length)]);
                if (nextpick >= 1 && nextpick <= 12 && Twopicked.ToLower() == "first" ||
                    nextpick >= 13 && nextpick <= 24 && Twopicked.ToLower() == "second" ||
                    nextpick >= 25 && nextpick <= 36 && Twopicked.ToLower() == "third")
                {

                    answer = answer * 3;
                    chips = answer + chips;
                    Console.WriteLine("You won " + answer + " chips");
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
                Console.WriteLine("You choose Columns: first, second, or third columns | chances of winning are 32.40%  Payout is * 3 ");
                Console.WriteLine("");
                Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                int answer;
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                {
                    Console.Write("Enter a number lesser or equal to your chips :");
                    Console.WriteLine("");
                }
                chips = chips - answer;
                Console.WriteLine("");
                Console.Write(" Choose  a column |first|second|third  : ");
                string Twopicked = Console.ReadLine();
                Random AA = new Random();
                string nextpick = COL[AA.Next(COL.Length)];
                Console.WriteLine("You landed on " + nextpick);

                if (Twopicked == nextpick)
                {

                    answer = answer * 3;
                    chips = answer + chips;
                    Console.WriteLine("You won " + answer + " chips");
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
            else if (choice.ToLower() == "g")
            {
                Console.WriteLine("You choose Street: rows,  1/2/3 or 22/23/24 | chances of winning are 7.9%  Payout is * 11");
                Console.WriteLine("");
                Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                int answer;
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                {
                    Console.Write("Enter a number lesser or equal to your chips :");
                    Console.WriteLine("");
                }
                chips = chips - answer;
                Console.WriteLine("");
                Console.Write("Choose a row 1/2/3|a| or 22/23/24|b| type a or b : ");
                string Twopicked = Console.ReadLine();
                
                int nextpick = numbers[AA.Next(numbers.Length)];
                Console.WriteLine("You landed on " + nextpick + " " + colors[AA.Next(colors.Length)]);

                if ((Twopicked.ToLower() == "a" && nextpick <= 3) || (Twopicked.ToLower() == "b" && nextpick >= 22 && nextpick <= 24))
                {
                    answer = answer * 11;
                    chips = answer + chips;
                    Console.WriteLine("You won " + answer + " chips ");
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
                Console.WriteLine("You choose 6 Numbers: double rows,  1/2/3/4/5/6 or 22/23/24/25/26/26 | chances of winning are 15.8%  Payout is * 5");
                Console.WriteLine("");
                Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                int answer;
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                {
                    Console.Write("Enter a number lesser or equal to your chips :");
                    Console.WriteLine("");
                }
                chips = chips - answer;
                Console.WriteLine("");
                Console.Write("Choose a row 1/2/3/4/5/6|a| or 22/23/24/25/26/27|b| type a or b : ");
                string Twopicked = Console.ReadLine();
                Random AA = new Random();
                int nextpick = numbers[AA.Next(numbers.Length)];
                Console.WriteLine("You landed on " + nextpick + " " + colors[AA.Next(colors.Length)]);

                if ((Twopicked.ToLower() == "a" && nextpick <= 6) || (Twopicked.ToLower() == "b" &&
                   nextpick >= 22 && nextpick <= 26))
                {
                    answer = answer * 5;
                    chips = answer + chips;
                    Console.WriteLine("You won " + answer + " chips ");
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
                Console.WriteLine("You choose Split: at the edge of any two contiguous numbers,  1/2, 11/14, and 35/36  | chances of winning  5.4%  Payout is * 17 ");
                Console.WriteLine("");
                Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                int answer;
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                {
                    Console.Write("Enter a number lesser or equal to your chips :");
                    Console.WriteLine("");
                }
                chips = chips - answer;
                Console.WriteLine("");
                Console.Write("Choose a edge  1/2|a| or 11/14|b| or 35/36|c| type a or b or c : ");
                string Twopicked = Console.ReadLine();
                Random AA = new Random();
                int nextpick = numbers[AA.Next(numbers.Length)];
                Console.WriteLine("You landed on " + nextpick + " " + colors[AA.Next(colors.Length)]);

                if ((Twopicked.ToLower() == "a" && nextpick <= 2) || (Twopicked.ToLower() == "b" &&
                    nextpick == 11 || nextpick == 14) || (Twopicked.ToLower() == "c"
                    && nextpick == 35 || nextpick == 36))
                {
                    answer = answer * 17;
                    chips = answer + chips;
                    Console.WriteLine("You won " + answer + " chips ");
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
                Console.WriteLine("You choose Corner: at the intersection of any four contiguous numbers,  1/2/4/5, or 23/24/26/27 | chances or winning  10.5%  Payout is * 8");
                Console.WriteLine("");
                Console.Write("You have " + chips + " chips how much would you like to put in ? : ");
                int answer;
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                {
                    Console.Write("Enter a number lesser or equal to your chips :");
                    Console.WriteLine("");
                }
                chips = chips - answer;
                Console.WriteLine("");
                Console.Write("Choose a intersection  1,2,4,5|a| or |b|23,24,26,27 type a or b  : ");
                string Twopicked = Console.ReadLine();
                Random JJ = new Random();
                int nextpick = numbers[JJ.Next(numbers.Length)];
                Console.WriteLine("You landed on " + nextpick + " " + colors[AA.Next(colors.Length)]);

                if ((Twopicked.ToLower() == "a" && nextpick <= 5) || (Twopicked.ToLower() == "b" &&
                    nextpick == 23 || nextpick == 24 || nextpick == 26
                    || nextpick == 27))
                {
                    answer = answer * 8;
                    chips = answer + chips;
                    Console.WriteLine("You won " + answer + " chips ");
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
