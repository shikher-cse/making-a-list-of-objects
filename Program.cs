using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string appinfo = "FRUITS LIST";
            string appversion = "3.0.1";
            string appauthor = "shikher raina";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("________________________________________________________________________________________");
            Console.WriteLine("This app {0} with the version  {1} is developed by  {2} ", appinfo, appversion, appauthor);
            Console.WriteLine("________________________________________________________________________________________");
            Console.ResetColor();


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                //int[] arr = new int[10];
                string[] arr = new string[10];


                int i;
                //Console.WriteLine();
                Console.WriteLine("===============================================================================================");
                Console.Write(" Please tell how many fruits you want in your basket?  \n");
                Console.Write("--------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                int input = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input {0} fruits name for putting in your basket  :\n", input);
                Console.WriteLine("_____________________________________________________________________________________");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (i = 1; i <= input; i++)
                {
                    Console.Write("Fruit  - {0} : ", i);
                    // arr[i] = Convert.ToInt32(Console.ReadLine());
                    arr[i] = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPlease check the fruits you added : ");
                Console.WriteLine("_______________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (i = 0; i <= input; i++)
                {
                    Console.Write("{0}  ", arr[i]);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();




                Console.WriteLine();
                Console.WriteLine("Do you want to perform any change in  your choice of fruits (Y or  N) ? ");
                string answer = Console.ReadLine().ToUpper();

                // check for the conditions of yes or no...
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (answer == "Y")
                {
                    Console.WriteLine(" please tell which fruit you want to  replace ? ");
                    string replacefruit = Console.ReadLine();



                    for (int t = 1; t <= input; t++)
                    {
                        if (replacefruit == arr[t])
                        {
                            Console.WriteLine(" please mention new fruit to replace it ");
                            string newfruit = Console.ReadLine();
                            arr[t] = newfruit;

                        }
                        continue;
                    }



                    Console.WriteLine();
                    Console.WriteLine(" please review the changes . are you okay with the choosen set of fruits ? press" +
                        " enter to continue or esc to abort ");

                    Console.WriteLine("____________________________________________________________________________");
                    for (i = 0; i <= input; i++)
                    {
                        Console.Write("{0}  ", arr[i]);
                    }

                    //functionality used for enter key and the escape key  ...
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                    if (consoleKeyInfo.Key == ConsoleKey.Enter)
                    {
                        int[] numtor = new int[20];
                        for (int k = 1; k <= input; k++)
                        {

                            Console.Write("how many  {0}   you need in your basket :-   ", arr[k].ToUpper());
                            numtor[k] = Convert.ToInt32(Console.ReadLine());

                        }
                        Console.WriteLine(" Please review the list made by you :- ");
                        Console.WriteLine("_____________________________________________________________");


                        for (int e = 1; e <= input; e++)
                        {

                            Console.WriteLine("|      you have {0}  number of {1}         ", numtor[e], arr[e] + "    |");


                        }
                        //for(int l = 1;l<=input;l++)
                        //{
                        //double sum  = sum  +  numtor[l];
                        //}


                    }

                    //{
                    //    continue;
                    //}
                    else if (consoleKeyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" tbe program is aborted as due to multiple correction ");
                        Console.WriteLine(" this is the choosen fruits , please run the program again  ! ");
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine();

                    }
                    else
                    {
                        return;
                    }

                }

                else if (answer == "N")

                {

                    // we will make a function for this as the same statement is getting used inside the enter key.
                    Console.WriteLine(" okay great as you have made the choice of number of fruits,  lets now mention the quantity:- ");

                    //made an integer array for input the integer element...
                    int[] numtor = new int[20];
                    for (int k = 1; k <= input; k++)
                    {

                        Console.Write("how many  {0}   you need in your basket :-   ", arr[k].ToUpper());
                        numtor[k] = Convert.ToInt32(Console.ReadLine());

                    }
                    Console.WriteLine(" Please review the list made by you :- ");
                    Console.WriteLine("________________________________________________________");


                    for (int e = 1; e <= input; e++)
                    {

                        Console.WriteLine("|      you have {0}  number of {1}         ", numtor[e], arr[e] + "    |");
                    }
                    Console.WriteLine("_________________________________________________________");
                }

                else 
                {
                    
                    Console.ReadLine();
                    return;
                }
            }


            Console.ReadLine();
        }

    }
}

