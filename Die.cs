using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Class
{
    public class Die
    {
        private Random _generator;
        private int _roll;
        private ConsoleColor _color;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
            _color = ConsoleColor.Gray;
        }
        
        public Die(ConsoleColor color)
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
            _color = color;
        }

        public int Roll
        {
            get { return _roll; }
            //set { _roll = value; }
        }

        public void RollDie()
        {
            _roll = _generator.Next(1, 7);
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void DrawRoll()
        {
            Console.ForegroundColor = _color;

            if (_roll == 1)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| O |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|O  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  O|");
                Console.WriteLine("-----");
            }
            else if (_roll == 3)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|O  |");
                Console.WriteLine("| O |");
                Console.WriteLine("|  O|");
                Console.WriteLine("-----");
            }
            else if (_roll == 4)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|O O|");
                Console.WriteLine("|   |");
                Console.WriteLine("|O O|");
                Console.WriteLine("-----");
            }
            else if (_roll == 5)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|O O|");
                Console.WriteLine("| O |");
                Console.WriteLine("|O O|");
                Console.WriteLine("-----");
            }
            else if (_roll == 6)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|O O|");
                Console.WriteLine("|O O|");
                Console.WriteLine("|O O|");
                Console.WriteLine("-----");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }




    }
}
