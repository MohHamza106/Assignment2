using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Remoting;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region value types 

            #region implicit casting - safe casting 
            //int x = 4; // 4 byte
            //long y =/*(long)*/ x;
            #endregion

            #region Explicit Casting - unsafe Casting
            //long x = 101010101010101010; //8byte
            //int y = x;  /*Error*/
            // // 
            // checked
            //{
            //    int y = (int)x; /*the command will give you exception so that is wrong */
            //}
            //Console.WriteLine(y);
            //int x = 88;
            //double y = /*(double)*/x;  /*implicit*/
            // // 

            //double x = 88.878;
            //int y = (int) x;          /*Explicit unsaved one */
            #endregion

            #region Parse [convert from string to any datatype]

            //int Number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter user ");

            //Console.Write("Enter Name : ");
            //string Name = Console.ReadLine();

            //Console.Write("Enter your Age ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.Write(" Enter Salary ");
            //double salary = double.Parse(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Name : "+ Name  + " Age "+Age + " Salary "+salary);
            #endregion

            #region Convert [ convert from any Datatype  to any datatype]
            //Console.WriteLine("Enter user ");

            //Console.Write("Enter Name : ");
            //string Name = Console.ReadLine();

            //Console.Write("Enter your Age ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write(" Enter Salary ");
            //double salary = Convert.ToDouble(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Name : " + Name + " Age " + Age + " Salary " + salary);
            #endregion


            #endregion

            #region Operators 
            #region unary [++,--]
            //int x = 5;
            //// x++ , x-- => prefix
            //// ++x , --x => postfix 
            //Console.WriteLine(x++);
            //Console.WriteLine(++x);
            //Console.WriteLine(x--);
            //Console.WriteLine(--x);

            #endregion

            #region Binary 

            //int Sum, Mul, Sub, Div, Mod;

            //int a = 10; 
            //int b = 5;

            //Sum = a+b;
            //Mul = a*b;
            //Sub = a-b;
            //Div = a/b;
            //Mod = a%b;

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul); 
            //Console.WriteLine(Sub);
            //Console.WriteLine(Div);
            //Console.WriteLine(Mod);


            #endregion

            #region Assignment 
            //int x = 10;
            //x += 10;
            //x -= 10;
            //x %= 10;
            //x *= 10;
            //x /= 10;

            #endregion

            #region Relational 
            //int A = 0;
            //int B = 10;

            //Console.WriteLine(A == B);
            //Console.WriteLine(A != B);
            //Console.WriteLine(A <= B);
            //Console.WriteLine(A >= B);
            //Console.WriteLine(A < B);
            //Console.WriteLine(A > B);

            #endregion

            #region logical 
            //Console.WriteLine(true && false); [Short Circuit]
            ////  true && true = true 
            //    true && false = false
            //    false && true = false
            //    false && false = false
            /////////////////////////
            ////  true || true = true 
            //    true || false = false
            //    false || true = false
            //    false || false = false
            /////////////////////////////////////////////////////////
            //Console.WriteLine(true && false); [long Circuit]
            ////  true & true = true 
            //    true & false = false
            //    false & true = false
            //    false & false = false
            /////////////////////////
            ////  true | true = true 
            //    true | false = false
            //    false | true = false
            //    false | false = false

            #endregion

            #region Ternary 
            //int x = 4;

            //string message = x > 4 ? " X greater than4 " : " X less than 4";
            #endregion

            #region Operator periorety 

            //int a = 5 ; 
            //int b = 6; 
            //int c = 7; 
            //int d = 8;

            //int result;

            //result = (a + b) * c / d; /* between bracet will be accomplish first then * then / */

            #endregion

            #region String Formating 
            //    int x = 0;
            //    int y = 10;
            //    int result = x+y;
            //Console.WriteLine("Equation :"+x + " + " + y +" = " + result);
            ///* it works but not efficient */
            ///

            /*to be fixed there are two ways */

            #region Composite Formate
            //int x = 0;
            //int y = 10;
            //int result = x + y;
            //string message = string.Format("Equation  = {0} + {1} = {2}",x,y,result);
            //Console.WriteLine(message);
            //Console.WriteLine("Equation  = {0} + {1} = {2}", x, y, result);


            #endregion

            #region String Manipolition
            //int x = 0;
            //int y = 10;
            //int result = x + y;

            //Console.WriteLine($"Equation = {x} + {y} = {result}");

            #endregion


            #endregion

            #region IF - Else - Switch Case 
            /*if-statment*/

            //Console.WriteLine("Enter Month Number");

            //int MonthNum = int.Parse(Console.ReadLine());

            //if (MonthNum==1)
            //{
            //    Console.WriteLine("Month is Jan");
            //}
            //else if (MonthNum==2) 
            //{
            //    Console.WriteLine("Month is Feb");
            //}
            //else if (MonthNum == 3)
            //{
            //    Console.WriteLine("Month is Mar");
            //}
            //else
            //{
            //    Console.WriteLine("not valid "); 
            //}


            /*Switch Case*/
            //Console.WriteLine("Enter Month Number");

            //int MonthNum = int.Parse(Console.ReadLine());

            //switch (MonthNum )
            //{
            //    case 1:
            //        Console.WriteLine("Month is Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Month is Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Month is Mar");
            //        break;
            //    default:
            //        Console.WriteLine("not valid ");
            //        break;
            //}

            #endregion

            #region goto [in Switch case]
            //int option = int.Parse(Console.ReadLine())

            //switch (option)
            //{
            //    case 3000:
            //        Console.WriteLine("option 03");
            //        goto case 2000;

            //    case 2000:
            //        Console.WriteLine("option 02");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 01");
            //        break;
            //    default:
            //        Console.WriteLine("not valid ");
            //        break;
            //}
            #endregion

            #region Evaluation in C# 
            /*in C# 6 */

            //int Age = int.Parse(Console.ReadLine());

            //switch (Age)
            //{
            //    case > 22 :
            //        Console.WriteLine("greater than 22");
            //        break;

            //    case <22:
            //        Console.WriteLine("less than 22");
            //        break; 

            //    default:
            //        Console.WriteLine(" Equal 22 ");
            //        break;
            //}

            /**********************************************/

            /*C# 7 */
            //object obj = new object();
            //obj = "ali";
            //obj = 18;
            //obj = true;



            //switch (obj)
            //{
            //    case int Num when Num > 30 && Num <15 : 
            //        Console.WriteLine($"{Num} is int ");
            //        break;

            //    case string Name:
            //        Console.WriteLine($"{Name} is Name ");
            //        break; 

            //    case bool Flag:
            //        Console.WriteLine($"{Flag} is bool ");
            //        break;

            //}

            /*************************************************/

            /*c# 08*/
            //Console.WriteLine("");
            //int option = int.Parse(Console.ReadLine());

            //string message = option switch
            //{
            //    1 => "option 01",
            //    2 => "option 02",
            //    3 => "option 03",
            //    _ => "Invalid"
            //}; 

            //Class1 Eo1 = new Class1();
            //Eo1.Name = "ali";
            //Eo1.Id = 5050;
            //Eo1.Age = 22;
            //string message = Eo1 switch
            //{
            //    { Id: 5050, Name: "aliaa", Age: 22 } => $"{Eo1.Id} : {Eo1.Name} : {Eo1.Age}",
            //    { Id: 5050, Name: "ahmed", Age: 22 } => $"{Eo1.Id} : {Eo1.Name} : {Eo1.Age}",
            //    { Id: 5050, Name: "mostafa", Age: 22 } => $"{Eo1.Id} : {Eo1.Name} : {Eo1.Age}"

            //};
            //Console.WriteLine(message);


            /*C# 9 */

            //Class1 Eo1 = new Class1();
            //Eo1.Name = "ali";
            //Eo1.Id = 5050;
            //Eo1.Age = 22;
            //string message = Eo1 switch
            //{
            //    {  Age: 22 and 25 } => $"{Eo1.Id} : {Eo1.Name} : {Eo1.Age}",
            //    {  Age: 22 or 30  } => $"{Eo1.Id} : {Eo1.Name} : {Eo1.Age}",
            //    {  Age: 22  } => $"{Eo1.Id} : {Eo1.Name} : {Eo1.Age}"

            //};
            //Console.WriteLine(message);



            #endregion


            #endregion
        }
    }
}
