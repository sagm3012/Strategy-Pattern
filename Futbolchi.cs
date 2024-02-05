using Attacker.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attacker
{
    internal class Futbolchi
    {
        private readonly string _name;
        private IStandart _standart;

        public Futbolchi(string name)
        {
            _name = name; 
        }
         public void SetStandart(IStandart standart)
        {
            _standart = standart;
        }
        public void ZarbaBeradi()
        {
            Console.WriteLine(">>>");
            if(_standart == null)
            {
                Console.WriteLine($"{_name} zarba bera olmaydi. Standart vaziyat turini tanlang");
                return;
            }
            Console.WriteLine($"{_name} top oldiga bordi");

            Console.Write(_name);

            _standart.Tepadi();
                
            Console.WriteLine($"{_name} jamoadoshlari bilan birga golni nishonladi");
        }
    }
}
