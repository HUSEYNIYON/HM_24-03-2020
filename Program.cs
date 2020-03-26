using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Exercise_2
            // Console.WriteLine("Exercise_2");
            // int A=Convert.ToInt32(Console.ReadLine());
            // int B=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("A="+A);
            // Console.WriteLine("B="+B);
            // if(A!=B)
            // {
            //     if(A>B)
            //     {
            //         Console.WriteLine("A="+A);
            //         Console.WriteLine("B="+(B=A));
            //     }
            //     else
            //     {
            //         Console.WriteLine("A="+(A=B));
            //         Console.WriteLine("B="+B);
            //     }                
            // }
            // else if(A==B)
            //      {
            //     Console.WriteLine("A="+(A=0));
            //     Console.WriteLine("B="+(B=0));
            //      }
            // Console.ReadLine();

            // //Exercise_2
            // Console.WriteLine("Exercise_3");
            // float a=15f;
            // float b=0f;
            // Console.Write("Enter a arithmetic sign: ");
            // string sign=Console.ReadLine();
            // switch(sign)
            // {
            //     case "+":
            //         Console.WriteLine("Sum="+(a+b));
            //         break;
            //     case "-":
            //         Console.WriteLine("Min="+(a-b));
            //         break;
            //     case "*":
            //         Console.WriteLine("Mul="+(a*b));
            //         break;
            //     case "/":
            //         if(b==0)
            //         {
            //             Console.WriteLine("Out of range!");
            //             break;
            //         }
            //         else
            //             Console.WriteLine("Div="+(a/b));
            //         break;
            //     default:
            //         Console.WriteLine("Incorrect sign!");
            //         break;
                    
            // }
            // Console.ReadLine();

            //Exercise_4
            Console.WriteLine("Exercise_4");
            int RandomNumber=Convert.ToInt32(Console.ReadLine());
                if((RandomNumber>=0)&&(RandomNumber<=14))
                        Console.WriteLine("Your number between [0-14]");   
                if((RandomNumber>=15)&&(RandomNumber<=35))
                        Console.WriteLine("Your number between [15-35]");   
                if((RandomNumber>=36)&(RandomNumber<=50))
                        Console.WriteLine("Your number between [35-50]");
                if((RandomNumber>=51)&&(RandomNumber<=100))   
                        Console.WriteLine("Your number between [51-100]");
                if((RandomNumber<0)||(RandomNumber>100))
                        Console.WriteLine("Out of range!");
            Console.ReadLine();            
        }
    }
}
