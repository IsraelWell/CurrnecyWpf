using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Dal
{
    public interface  IDal
    {
        void addRate(CurrencyRate c);
        CurrencyRate getRate(string currencyName, DateTime date);
        IEnumerable<CurrencyRate> getRatesForDate(DateTime date);
        IEnumerable<CurrencyRate> getRatesForDateRange(string currencyName, DateTime start, DateTime end);
        IEnumerable<CurrencyRate> getMultipleRates(IEnumerable<string> currencyNames, DateTime date);
        IEnumerable<CurrencyRate> getMultipleRatesForDateRange(IEnumerable<string> currencyNames, DateTime start, DateTime end);

    }
}
