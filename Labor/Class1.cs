using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor
{
    class Point
    {
        int x;
        int y;
        char sym;
        public void SetX (int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Значение x не может быть отрицательным");

        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Значение y не может быть отрицательным");
        }
        public void SetSym (char symbol)
        {
            sym = symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);

            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("*---*");

            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine(" * *");

            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("  *");
        }
    }
    class Programm
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            int x = -1;
            p.SetX(x);
            int y = 10;
            p.SetY(y);
            char sym = ' ';
            p.SetSym(sym);
            p.Draw();
            Console.ReadKey();
        }
    }
}
