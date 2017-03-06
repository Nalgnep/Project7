using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project7
{
    class Program
    {
        static void Main(string[] args)
        {
           //接口是一种能力，规范，I开头。。。able结尾
            IKouLan k1 = new Teacher();
            k1.KouLan();
            Console.ReadKey();
        }
    }

    class Person
    {
        public void CHLSS()
        {
            Console.WriteLine("CHLSS");
        }
    }

    class Teacher:Person,IKouLan
    {
        public void KouLan()
        {
            Console.WriteLine("老师可以扣篮");
        }
    }

    class Student:Person,IKouLan
    {
        public void KouLan()
        {
            Console.WriteLine("学生可以扣篮");
        }
    }

    interface IKouLan
    {
        void KouLan();
    }

    class NBAPlayer : Person
    {
        public void KouLan()
        {
            Console.WriteLine("koulan");
        }

    }


}
