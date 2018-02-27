using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Models;
using CurrencyRatesGetter;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            ICurrencyGetter c = new CurrencyGetter();
            Task<IEnumerable<CurrencyRate>> answer = c.GetRates();
            answer.Wait();
            
            Console.WriteLine();
           
        }
    }
}
