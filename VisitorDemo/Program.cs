using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IVisitable[] myList = { new Red(), new Red(), new Blue(), new Yellow(), new Yellow() };

            foreach(var v in myList)
            {
                v.Accept(new Visitor1());
            }

            foreach (var v in myList)
            {
                v.Accept(new Visitor2());
            }

            Console.ReadKey();
        }
    }

    interface IVisitable
    {
        void Accept(IVisitor visitor);
    }

    class Red : IVisitable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string CheckRed()
        {
            return "It was indeed me, RED!";
        }
    }

    class Blue : IVisitable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string ValidateBlue()
        {
            return "It's a me, BLUE!";
        }
    }

    class Yellow : IVisitable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string OkayYellow()
        {
            return "YELLOW it is!";
        }
    }

    class Visitor1 :IVisitor
    {
        public void Visit(Red visitable)
        {
            Console.WriteLine("RED");
            Console.WriteLine(visitable.CheckRed());
        }

        public void Visit(Blue visitable)
        {
            Console.WriteLine("BLUE");
            Console.WriteLine(visitable.ValidateBlue());
        }

        public void Visit(Yellow visitable)
        {
            Console.WriteLine("YELLOW");
            Console.WriteLine(visitable.OkayYellow());
        }
    }

    class Visitor2 : IVisitor
    {
        public void Visit(Red visitable)
        {
            Console.WriteLine("RED2");
            Console.WriteLine(visitable.CheckRed());
        }

        public void Visit(Blue visitable)
        {
            Console.WriteLine("BLUE2");
            Console.WriteLine(visitable.ValidateBlue());
        }

        public void Visit(Yellow visitable)
        {
            Console.WriteLine("YELLOW2");
            Console.WriteLine(visitable.OkayYellow());
        }
    }

    interface IVisitor
    {
        void Visit(Red visitable);
        void Visit(Blue visitable);
        void Visit(Yellow visitable);
    }
}
