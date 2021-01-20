using System;

namespace Lesson1
{
    public class Homoework
    {

        public void Task1()
        {
            double a = 0, b = 0, ans =0; 

            a= Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

            ans = a * b;
            ans = Math.Sqrt(ans);

            Console.WriteLine(ans);
        }
        public void Task2()
        {
            double a, b, c, AC, BC, Ans;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            AC = Math.Abs(a - c);
            BC = Math.Abs(b - c);
            Ans = AC + BC; 
            
            Console.WriteLine(AC);
            Console.WriteLine(BC);
            Console.WriteLine(Ans);
        }
        public void Task3()
        {
            double x1, x2, y1, y2, ans, a, b;

            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());

            a = Math.Pow((x1 - x2), 2);
            b = Math.Pow((y1 - y2), 2);
            ans = Math.Sqrt(a + b);

            Console.WriteLine(ans);
        }
        public void Task4()
        {
            int x, ans;

            x = Convert.ToInt32(Console.ReadLine());

            ans = x % 10;
            ans *= 10;
            ans += x / 10;        

            Console.WriteLine(ans);
        }
        public void Task5()
        {
            int x, ans;

            x = Convert.ToInt32(Console.ReadLine());

            ans = x / 60;

            Console.WriteLine(ans);
        }
        public void Task6()
        {
            int K, ans;

            K = Convert.ToInt32(Console.ReadLine());

            ans = K % 7;

            Console.WriteLine(ans);
        }

    }

    class Program
    {
        
        static void Main(string[] args)
        {
            var HM = new Homoework();//все домашки сделал в классе "Homework" 
            HM.Task1(); //надо взват метода которого следует посмотреть
        }
        
    }
}