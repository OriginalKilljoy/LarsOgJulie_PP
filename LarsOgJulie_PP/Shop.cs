using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarsOgJulie_PP
{
    internal class Shop
    {
        public string _shopName { get; set; }
        public string _shopType { get; set; }
        public int _shopPrice { get; set; }

        public void PrintInfo()
        {
            

            Console.WriteLine("Navn: " + _shopName);
            Console.WriteLine("Type: " + _shopType);
            Console.Write("Pris: ");
            ChangePrice();
            Console.WriteLine();
        }

        public Shop(string shopName, string shopType, int shopPrice)
        {
            _shopName = shopName;
            _shopType = shopType;
            _shopPrice = shopPrice;
        }
        public void ChangePrice()
        {
            if (_shopPrice == 1)
            {
                Console.WriteLine("Billig");
            }
            else if (_shopPrice == 2)
            {
                Console.WriteLine("Middels");
            }
            else
            {
                Console.WriteLine("Dyr");
            }
        }
    }
}
