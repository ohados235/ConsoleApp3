using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

        }



        //1) פעולה המקבלת מספר ומחזירה את סכום ספרותיו שלו 
        public static int SumNums(int num)
        {
          
            if (num == 0) return 0;
            else
            {
                return SumNums(num / 10) + num % 10;
            }
        }



        //2) פעולה המקבלת מספר וסופרת את מס ספרותיו זוגיות 
        public static int sumEvens(int x)
        {

           if(x == 0) return 0;
           if(x%2 == 0)
            {
              
                return sumEvens(x/10)+1;
            }
            else
            {
                return sumEvens(x / 10);
            }

        }
        //פעולה המקבלת מספר וספרה ומחזירה אמת אם הספרה נמצאת במספר (3
        public static bool In(int num, int digit)
        {
            if (num == 0)
            {
                return false;
            }
            if (num % 10 == digit)
            {
                return true;
            }
            return In(num / 10, digit);

        }


        //4) פעולה המקבלת מספר ומחזירה אמת אם כל ספרותיו זוגיות
        public static bool In(int num)
        {
            if (num == 0) return true;

            if (!(num % 10 % 2 == 0))
            {
                return false;
            }

            return In(num / 10);


        }



        //4b)  פעולה המקבלת מספר ומחזירה את סכום ספרותיו מהמספר ועד 1
        public static int Sum(int num)
        {
            if (num == 1) return 1;

            else
            {
                return Sum(num - 1) + num;
            }
        }


        //5) פעולה המחזירה עצרת של הקלט
        public static int azeret(int x)
        {
            if (x == 1)
            {
                return 1;
            }

            return azeret(x - 1) * x;
        }

        //פעולה הבודקת האם שני המספרים שווים באורכם
        // מחזירה אמת או שקר
        public static bool Identical(int num1, int num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                return true;
            }
            else
            {
                if (num1 == 0 ||  num2 == 0)
                {
                    return false;
                }
            }
            return Identical(num1/10, num2/10);
        }





      


       




      
        
    }
    }
