using System;
using System.Linq;
using System.Collections.Generic;

namespace DivMulCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Title = "GWE's Divisor & Multiple Calculator";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("GWE's DIVISOR & MULIPLE CALCULATOR\nWelcome! Are you having trouble with your divisor and multiple math problems?\nWell, if so, this tool is for you!\n");
                Console.WriteLine("But first... I need you to choose what you wanna calculate.");
                Console.WriteLine("\n\n\n[1] Calculate divisors\n[2] Calculate multiples\n[3] Calculate multiples w/ number limit\n[4] Quit");
                Console.Write("Your choice: ");
                try
                {
                    a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Main_Div();
                            break;
                        case 2:
                            Main_Mul();
                            break;
                        case 3:
                            Main_Mul_Num();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Hmm... Is there any way I can make you choose the right option in C#?");
                            Console.ReadLine();
                            continue;
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("MY SYSTEM CRASHED! I LOST MY DEETA!\nError Type  : " + e.GetType().ToString() + "\nError Reason: " + e.Message + "\n\nThe error happened...\n" + e.StackTrace + "\n\nPress any key to restart the program...");
                    Console.ReadLine();
                }
            }
        }
        static void Main_Div()
        {
            int a;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("GWE's DIVISOR & MULIPLE CALCULATOR\nWelcome! Are you having trouble with your divisor and multiple math problems?\nWell, if so, this tool is for you!\n");
                Console.WriteLine("But first... I need you to choose what you wanna calculate.");
                Console.WriteLine("\nCalculate divisors\n\n[1] Calculate all divisors\n[2] Calculate common divisors\n[3] Back");
                Console.Write("Your choice: ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Calc_Div();
                        break;
                    case 2:
                        Main_ComDiv();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Hmm... Is there any way I can make you choose the right option in C#?");
                        Console.ReadLine();
                        continue;
                }
            }
        }
        static void Main_ComDiv()
        {
            int a;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("GWE's DIVISOR & MULIPLE CALCULATOR\nWelcome! Are you having trouble with your divisor and multiple math problems?\nWell, if so, this tool is for you!\n");
                Console.WriteLine("But first... I need you to choose what you wanna calculate.");
                Console.WriteLine("\nCalculate divisors > Calculate common divisors\n\n[1] Calculate all common divisors\n[2] Calculate largest common divisor\n[3] Back");
                Console.Write("Your choice: ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Calc_ComDiv();
                        break;
                    case 2:
                        Calc_LarComDiv();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Hmm... Is there any way I can make you choose the right option in C#?");
                        Console.ReadLine();
                        continue;
                }
            }
        }
        static void Main_Mul()
        {
            int a;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("GWE's DIVISOR & MULIPLE CALCULATOR\nWelcome! Are you having trouble with your divisor and multiple math problems?\nWell, if so, this tool is for you!\n");
                Console.WriteLine("But first... I need you to choose what you wanna calculate.");
                Console.WriteLine("\nCalculate multiples\n\n[1] Calculate all multiples\n[2] Calculate common multiples\n[3] Back");
                Console.Write("Your choice: ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Calc_Mul();
                        break;
                    case 2:
                        Main_ComMul();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Hmm... Is there any way I can make you choose the right option in C#?");
                        Console.ReadLine();
                        continue;
                }
            }
        }
        static void Main_ComMul()
        {
            int a;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("GWE's DIVISOR & MULIPLE CALCULATOR\nWelcome! Are you having trouble with your divisor and multiple math problems?\nWell, if so, this tool is for you!\n");
                Console.WriteLine("But first... I need you to choose what you wanna calculate.");
                Console.WriteLine("\nCalculate multiples > Calculate common multiples\n\n[1] Calculate all common multiples\n[2] Calculate smallest (non-zero) common multiple\n[3] Back");
                Console.Write("Your choice: ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Calc_ComMul();
                        break;
                    case 2:
                        Calc_SmaComMul();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Hmm... Is there any way I can make you choose the right option in C#?");
                        Console.ReadLine();
                        continue;
                }
            }
        }
        static void Main_Mul_Num()
        {
            int a;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("GWE's DIVISOR & MULIPLE CALCULATOR\nWelcome! Are you having trouble with your divisor and multiple math problems?\nWell, if so, this tool is for you!\n");
                Console.WriteLine("But first... I need you to choose what you wanna calculate.");
                Console.WriteLine("\nCalculate multiples w/ number limit\n\n[1] Calculate all multiples\n[2] Calculate common multiples\n[3] Back");
                Console.Write("Your choice: ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Calc_Mul_Num();
                        break;
                    case 2:
                        Main_ComMul_Num();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Hmm... Is there any way I can make you choose the right option in C#?");
                        Console.ReadLine();
                        continue;
                }
            }
        }
        static void Main_ComMul_Num()
        {
            int a;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("GWE's DIVISOR & MULIPLE CALCULATOR\nWelcome! Are you having trouble with your divisor and multiple math problems?\nWell, if so, this tool is for you!\n");
                Console.WriteLine("But first... I need you to choose what you wanna calculate.");
                Console.WriteLine("\nCalculate multiples w/ number limit > Calculate common multiples\n\n[1] Calculate all common multiples\n[2] Calculate smallest (non-zero) common multiple\n[3] Back");
                Console.Write("Your choice: ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Calc_ComMul_Num();
                        break;
                    case 2:
                        Calc_SmaComMul_Num();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Hmm... Is there any way I can make you choose the right option in C#?");
                        Console.ReadLine();
                        continue;
                }
            }
        }
        static void Calc_Div()
        {
            int n;
            int count = 0;
            Console.Clear();
            Console.WriteLine("All right! Time to calculate. I just need the number you wanna find the divisors of.");
            Console.Write("Now type a number, then I'll calculate its divisors! ");
            n = int.Parse(Console.ReadLine());
            Console.Write("The divisor(s) of " + n + " is/are: ");
            for (int i = 1; i < n + 1; i++)
            {
                if (n % i == 0)
                {
                    if (count == 0)
                    {
                        Console.Write(i);
                        count++;
                    }
                    else
                    {
                        Console.Write(", " + i);
                        count++;
                    }
                }
            }
            Console.WriteLine("\nFound {0} divisors of {1}\n", count, n);
            Console.WriteLine("Finished! Press Enter to return.");
            Console.ReadLine();
            return;
        }
        static void Calc_ComDiv()
        {
            
            int ncount;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("All right! Time to calculate. I just need some numbers you wanna find the common divisors of.");
                Console.Write("Now type how many numbers you wanna calculate (minimum 2 numbers): ");
                ncount = int.Parse(Console.ReadLine());
                if (ncount < 2)
                {
                    Console.WriteLine("How p a t h e t i c . Calculating common divisors of less than 1 number won't work.");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    break;
                }
            }
            com[] n = new com[ncount];
            int currn = 0;
            List<int> completecom = new List<int>();
            List<int> tempcom = new List<int>();
            Console.WriteLine("All right, this is about to get real crazy.");
            while (currn < ncount)
            {
                n[currn] = new com();
                Console.Write("Type Number No. {0}! ", currn + 1);
                n[currn].num = int.Parse(Console.ReadLine());
                currn++;
                Console.WriteLine("Calculating divisors for {0}... This may take a while depending on how big the number is.", n[currn - 1].num);
                for (int i = 1; i < n[currn - 1].num + 1; i++)
                {
                    if (n[currn - 1].num % i == 0)
                    {
                        n[currn - 1].list.Add(i);
                    }

                }
                Console.WriteLine("Finished calculating divisors!\n");
                if (currn - 1 == 1)
                {
                    Console.WriteLine("Calculating common divisors... This may take a while.");
                    completecom = n[0].list.Intersect(n[currn - 1].list).ToList();
                    Console.WriteLine("Finished calculating common divisors!\n");
                    continue;
                }
                else if (currn - 1 > 1)
                {
                    Console.WriteLine("Calculating common divisors...");
                    tempcom.AddRange(completecom);
                    completecom.Clear();
                    completecom = tempcom.Intersect(n[currn - 1].list).ToList();
                    Console.WriteLine("Finished calculating common divisors!\n");
                }
            }
            Console.Write("\nAnd it's done. Your common divisor(s) is/are: ");
            completecom.Sort();
            foreach (var item in completecom)
            {
                if (item == completecom[0])
                {
                    Console.Write(item);
                }
                else
                {
                    Console.Write(", " + item);
                }
            }
            Console.Write("\nFound {0} common divisor(s) of ", completecom.Count);
            for (int i = 0; i < ncount; i++)
            {
                if (i == 0)
                {
                    Console.Write(n[i].num);
                }
                else
                {
                    Console.Write(", " + n[i].num);
                }
            }
            Console.WriteLine("\nFinished! Press Enter to return.");
            Console.ReadLine();
            return;
        }
        static void Calc_LarComDiv()
        {
            int ncount;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("All right! Time to calculate. I just need some numbers you wanna find the largest common divisor of.");
                Console.Write("Now type how many numbers you wanna calculate (minimum 2 numbers): ");
                ncount = int.Parse(Console.ReadLine());
                if (ncount < 2)
                {
                    Console.WriteLine("How p a t h e t i c . Calculating the largest common divisor of less than 1 number won't work.");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    break;
                }
            }
            com[] n = new com[ncount];
            int currn = 0;
            List<int> completecom = new List<int>();
            List<int> tempcom = new List<int>();
            Console.WriteLine("All right, this is about to get real crazy.");
            while (currn < ncount)
            {
                n[currn] = new com();
                Console.Write("Type Number No. {0}! ", currn + 1);
                n[currn].num = int.Parse(Console.ReadLine());
                currn++;
                Console.WriteLine("Calculating divisors for {0}... This may take a while depending on how big the number is.", n[currn - 1].num);
                for (int i = 1; i < n[currn - 1].num + 1; i++)
                {
                    if (n[currn - 1].num % i == 0)
                    {
                        n[currn - 1].list.Add(i);
                    }

                }
                Console.WriteLine("Finished calculating divisors!\n");
                if (currn - 1 == 1)
                {
                    Console.WriteLine("Calculating common divisors... This may take a while.");
                    completecom = n[0].list.Intersect(n[currn - 1].list).ToList();
                    Console.WriteLine("Finished calculating common divisors!\n");
                    continue;
                }
                else if (currn - 1 > 1)
                {
                    Console.WriteLine("Calculating common divisors... This may take a while.");
                    tempcom.AddRange(completecom);
                    completecom.Clear();
                    completecom = tempcom.Intersect(n[currn - 1].list).ToList();
                    Console.WriteLine("Finished calculating common divisors!\n");
                }
            }
            Console.WriteLine("\nWell, my gosh. What can I say except \"Baby, you're finding the largest common divisor of");
            for (int i = 0; i < ncount; i++)
            {
                if (i == 0)
                {
                    Console.Write(n[i].num);
                }
                else
                {
                    Console.Write(", " + n[i].num);
                }
            }
            int larcomdiv = completecom.Max();
            Console.Write(" so this is the final result heard all around the world, it's {0}!\"", larcomdiv);
            Console.WriteLine("\nFinished! Press Enter to return.");
            Console.ReadLine();
            return;
        }
        static void Calc_Mul()
        {
            int mullimit;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Multiples of numbers are infinite and never end!\nYou have to type a limit first.");
                Console.Write("Specify how many non-zero multiples should get displayed on-screen: ");
                mullimit = int.Parse(Console.ReadLine());
                if (mullimit == 0)
                {
                    Console.WriteLine("Really? You don't want any non-zero multiples to get displayed? You just want a big fat 0?");
                    Console.ReadLine();
                    continue;
                }
                else if (mullimit == 1)
                {
                    Console.WriteLine("One? Just ONE? All right then, see the consequences...");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    break;
                }
            }
            int n;
            bool firstmul = true;
            Console.Clear();
            Console.WriteLine("All right! Time to calculate. I just need the number you wanna find the multiples of.");
            Console.Write("Now type a number, then I'll calculate its multiples! ");
            n = int.Parse(Console.ReadLine());
            Console.Write("The first " + (mullimit + 1) + " multiples of " + n + " are: ");
            int j = 0;
            for (int i = 0; i <= mullimit; i++)
            {
                if (j % n == 0)
                {
                    if (firstmul == true)
                    {
                        Console.Write(j);
                        firstmul = false;
                        for (int k = 0; k < n; k++)
                        {
                            j++;
                        }
                    }
                    else
                    {
                        Console.Write(", " + j);
                        for (int k = 0; k < n; k++)
                        {
                            j++;
                        }
                    }
                }
            }
            Console.WriteLine("\nFinished! Press Enter to return.");
            Console.ReadLine();
            return;
        }
        static void Calc_ComMul()
        {
            int mullimit;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Multiples of numbers are infinite and never end!\nYou have to type a limit first.");
                Console.Write("Specify how many non-zero multiples should be used to calculate common multiples: ");
                mullimit = int.Parse(Console.ReadLine());
                if (mullimit == 0)
                {
                    Console.WriteLine("Really? You don't want any non-zero multiples to be used? You just want a big fat 0?");
                    Console.ReadLine();
                    continue;
                }
                else if (mullimit == 1)
                {
                    Console.WriteLine("One? Just ONE? All right then, see the consequences...");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    break;
                }
            }
            int ncount;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("All right! Time to calculate. I just need some numbers you wanna find the common multiples of.");
                Console.Write("Now type how many numbers you wanna calculate (minimum 2 numbers): ");
                ncount = int.Parse(Console.ReadLine());
                if (ncount < 2)
                {
                    Console.WriteLine("How p a t h e t i c . Calculating common multiples of less than 1 number won't work.");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    break;
                }
            }
            com[] n = new com[ncount];
            int currn = 0;
            List<int> completecom = new List<int>();
            List<int> tempcom = new List<int>();
            Console.WriteLine("All right, this is about to get real crazy.");
            while (currn < ncount)
            {
                n[currn] = new com();
                Console.Write("Type Number No. {0}! ", currn + 1);
                n[currn].num = int.Parse(Console.ReadLine());
                currn++;
                Console.WriteLine("Calculating the first {0} multiples for {1}... This may take a while depending on how big the number is.", mullimit + 1, n[currn - 1].num);
                int j = 0;
                for (int i = 0; i <= mullimit; i++)
                {
                    n[currn - 1].list.Add(j);
                    for (int k = 0; k < n[currn - 1].num; k++)
                    {
                        j++;
                    }
                }
                Console.WriteLine("Finished calculating multiples!\n");
                if (currn - 1 == 1)
                {
                    Console.WriteLine("Calculating common multiples... This may take a while.");
                    completecom = n[0].list.Intersect(n[currn - 1].list).ToList();
                    Console.WriteLine("Finished calculating common multiples!\n");
                    continue;
                }
                else if (currn - 1 > 1)
                {
                    Console.WriteLine("Calculating common multiples... This may take a while.");
                    tempcom.AddRange(completecom);
                    completecom.Clear();
                    completecom = tempcom.Intersect(n[currn - 1].list).ToList();
                    Console.WriteLine("Finished calculating common multiples!\n");
                }
            }
            Console.Write("\nAnd it's done. Your common multiple(s) is/are: ");
            completecom.Sort();
            foreach (var item in completecom)
            {
                if (item == completecom[0])
                {
                    Console.Write(item);
                }
                else
                {
                    Console.Write(", " + item);
                }
            }
            Console.Write("\nFound {0} common multiple(s) of the first {1} multiples of ", completecom.Count, mullimit + 1);
            for (int i = 0; i < ncount; i++)
            {
                if (i == 0)
                {
                    Console.Write(n[i].num);
                }
                else
                {
                    Console.Write(", " + n[i].num);
                }
            }
            Console.WriteLine("\nFinished! Press Enter to return.");
            Console.ReadLine();
            return;
        }
        static void Calc_SmaComMul()
        {
            Console.Clear();
            Console.WriteLine("Multiples of numbers are infinite and never end!\nYou need a limit first.");
            Console.WriteLine("BUT in this case, limits are... pretty much useless, so instead, I'll use the first 1000 multiples of\nthe numbers you input! It ensures that NO ERROR WILL OCCUR.\nPress Enter to continue.");
            Console.ReadLine();
            int ncount;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("All right! Time to calculate. I just need some numbers you wanna find the smallest (non-zero) common multiple of.");
                Console.Write("Now type how many numbers you wanna calculate (minimum 2 numbers): ");
                ncount = int.Parse(Console.ReadLine());
                if (ncount < 2)
                {
                    Console.WriteLine("How p a t h e t i c . Calculating common multiples of less than 1 number won't work.");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    break;
                }
            }
            com[] n = new com[ncount];
            int currn = 0;
            List<int> completecom = new List<int>();
            List<int> tempcom = new List<int>();
            Console.WriteLine("All right, this is about to get real crazy.");
            while (currn < ncount)
            {
                n[currn] = new com();
                Console.Write("Type Number No. {0}! ", currn + 1);
                n[currn].num = int.Parse(Console.ReadLine());
                currn++;
                Console.WriteLine("Calculating multiples for {0}... This may take a while depending on how big the number is.", n[currn - 1].num);
                int j = 0;
                for (int i = 0; i <= 1000; i++)
                {
                    n[currn - 1].list.Add(j);
                    for (int k = 0; k < n[currn - 1].num; k++)
                    {
                        j++;
                    }
                }
                Console.WriteLine("Finished calculating multiples!\n");
                if (currn - 1 == 1)
                {
                    Console.WriteLine("Calculating common multiples... This may take a while.");
                    completecom = n[0].list.Intersect(n[currn - 1].list).ToList();
                    Console.WriteLine("Finished calculating common multiples!\n");
                    continue;
                }
                else if (currn - 1 > 1)
                {
                    Console.WriteLine("Calculating common multiples... This may take a while.");
                    tempcom.AddRange(completecom);
                    completecom.Clear();
                    completecom = tempcom.Intersect(n[currn - 1].list).ToList();
                    Console.WriteLine("Finished calculating common multiples!\n");
                }
            }
            Console.Write("\nWell, my gosh. What can I say except \"Baby, you're finding the smallest non-zero common multiple of\n");
            for (int i = 0; i < ncount; i++)
            {
                if (i == 0)
                {
                    Console.Write(n[i].num);
                }
                else
                {
                    Console.Write(", " + n[i].num);
                }
            }
            completecom.Remove(0);
            int smacommul = completecom.Min();
            Console.WriteLine(" so this is the final result heard all around the world, it's {0}!\"\n", smacommul);
            Console.WriteLine("Finished! Press Enter to return.");
            Console.ReadLine();
            return;
        }
        static void Calc_Mul_Num()
        {
            int mullimit;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Multiples of numbers are infinite and never end!\nYou have to type a limit first.");
                Console.Write("Specify a number limit for the multiples: ");
                mullimit = int.Parse(Console.ReadLine());
                if (mullimit == 0)
                {
                    Console.WriteLine("Really? ZERO??? That's gotta be stupid. Nope!");
                    Console.ReadLine();
                    continue;
                }
                else if (mullimit == 1)
                {
                    Console.WriteLine("One? Just ONE? All right then, see the consequences...");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    break;
                }
            }
            int n;
            bool firstmul = true;
            Console.Clear();
            Console.WriteLine("All right! Time to calculate. I just need the number you wanna find the multiples of.");
            Console.Write("Now type a number, then I'll calculate its multiples! ");
            n = int.Parse(Console.ReadLine());
            Console.Write("The multiples of " + n + " under " + mullimit + " are: ");
            int j = 0;
            while (j < mullimit)
            {
                if (j % n == 0)
                {
                    if (firstmul == true)
                    {
                        Console.Write(j);
                        firstmul = false;
                        for (int k = 0; k < n; k++)
                        {
                            j++;
                        }
                    }
                    else
                    {
                        Console.Write(", " + j);
                        for (int k = 0; k < n; k++)
                        {
                            j++;
                        }
                    }
                }
            }
            Console.WriteLine("\nFinished! Press Enter to return.");
            Console.ReadLine();
            return;
        }
        static void Calc_ComMul_Num()
        {
            int mullimit;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Multiples of numbers are infinite and never end!\nYou have to type a limit first.");
                Console.Write("Specify a number limit for the multiples: ");
                mullimit = int.Parse(Console.ReadLine());
                if (mullimit == 0)
                {
                    Console.WriteLine("Really? ZERO??? That's gotta be stupid. Nope!");
                    Console.ReadLine();
                    continue;
                }
                else if (mullimit == 1)
                {
                    Console.WriteLine("One? Just ONE? All right then, see the consequences...");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    break;
                }
            }
            int ncount;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("All right! Time to calculate. I just need some numbers you wanna find the common multiples of.");
                Console.Write("Now type how many numbers you wanna calculate (minimum 2 numbers): ");
                ncount = int.Parse(Console.ReadLine());
                if (ncount < 2)
                {
                    Console.WriteLine("How p a t h e t i c . Calculating common multiples of less than 1 number won't work.");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    break;
                }
            }
            com[] n = new com[ncount];
            int currn = 0;
            int j;
            List<int> completecom = new List<int>();
            List<int> tempcom = new List<int>();
            Console.WriteLine("All right, this is about to get real crazy.");
            while (currn < ncount)
            {
                n[currn] = new com();
                Console.Write("Type Number No. {0}! ", currn + 1);
                n[currn].num = int.Parse(Console.ReadLine());
                currn++;
                Console.WriteLine("Calculating multiples for {0} under {1}... This may take a while depending on how big the number is.", n[currn - 1].num, mullimit);
                j = 0;
                while (j < mullimit)
                {
                    n[currn - 1].list.Add(j);
                    for (int k = 0; k < n[currn - 1].num; k++)
                    {
                        j++;
                    }
                }
                Console.WriteLine("Finished calculating multiples!\n");
                if (currn - 1 == 1)
                {
                    Console.WriteLine("Calculating common multiples... This may take a while.");
                    completecom = n[0].list.Intersect(n[currn - 1].list).ToList();
                    Console.WriteLine("Finished calculating common multiples!\n");
                    continue;
                }
                else if (currn - 1 > 1)
                {
                    Console.WriteLine("Calculating common multiples... This may take a while.");
                    tempcom.AddRange(completecom);
                    completecom.Clear();
                    completecom = tempcom.Intersect(n[currn - 1].list).ToList();
                    Console.WriteLine("Finished calculating common multiples!\n");
                }
            }
            Console.Write("\nAnd it's done. Your common multiple(s) is/are: ");
            completecom.Sort();
            foreach (var item in completecom)
            {
                if (item == completecom[0])
                {
                    Console.Write(item);
                }
                else
                {
                    Console.Write(", " + item);
                }
            }
            Console.Write("\nFound {0} common multiple(s) of multiples of ", completecom.Count);
            for (int i = 0; i < ncount; i++)
            {
                if (i == 0)
                {
                    Console.Write(n[i].num);
                }
                else
                {
                    Console.Write(", " + n[i].num);
                }
            }
            Console.WriteLine("under {0}\nFinished! Press Enter to return.", mullimit);
            Console.ReadLine();
            return;
        }
        static void Calc_SmaComMul_Num()
        {
            Console.Clear();
            Console.WriteLine("Actually, using a number limit to calculate the smallest common multiple\nis STILL useless, so I'll just redirect you to the other version.");
            Console.ReadLine();
            Calc_SmaComMul();
            return;
        }
    }
    public class com
    {
        public int num;
        public List<int> list = new List<int>();
    }
}
