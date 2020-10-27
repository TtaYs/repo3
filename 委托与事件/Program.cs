using Microsoft.VisualBasic.CompilerServices;
using System;

namespace 委托与事件
{
    class Program
    {
      public    delegate int  mynum(int n);
        event mynum yournum;
        static void Main(string[] args)
        {
            /*
          mynum  m1 = new mynum(Addnum);
            mynum m2 = new mynum(Multnum);
            mynum m3 = new mynum(DIVnum);
            m1(5);
            m2(10);
            m3(30);
            */
            Program p = new Program();
           // DIVnum(10);
            p.yournum += new mynum(Addnum);
            p.yournum += new mynum(Multnum);
            p.yournum += new mynum(DIVnum);
            p.yournum(10);
            Console.Read();
        }
       static int num = 10;
        public static  int number() {
            return num;
        }
   
        public static  int Addnum(int n) {
            num += n;
            Console.WriteLine("n:{0} num+n运算结果为" + number(),n);
            return num;
           
        }
        public static int Multnum(int n) {
            num *= n;
            Console.WriteLine("n:{0} num*n运算结果为" + number(),n);
            return num;
        }
        public static int DIVnum(int n) {
            num /= n;
            Console.WriteLine("n:{0} num/n运算结果为"+number(),n);
            return num;
        }
    }
}
