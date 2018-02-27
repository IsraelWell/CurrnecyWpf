using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Models;
namespace Dal
{

    

    public class CurrencyDal: IDal
    {
        private SQLiteConnection con;
    
        public CurrencyDal()
        {
            con = new SQLiteConnection("MyData.db");
            con.CreateTable<CurrencyRate>();
        }

        public void addRate(CurrencyRate currencyRate)
        {
            con.Insert(currencyRate); 
        }

        public CurrencyRate getRate(string currencyName, DateTime date)
        {
            return con.Table<CurrencyRate>().Where(c => c.Name == currencyName && c.Date == date).FirstOrDefault();
        }

        public IEnumerable<CurrencyRate> getRatesForDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CurrencyRate> getMultipleRates(IEnumerable<string> currencyNames, DateTime date)
        {
            throw new NotImplementedException();

        }

        public IEnumerable<CurrencyRate> getRatesForDateRange(string currencyName, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CurrencyRate> getMultipleRatesForDateRange(IEnumerable<string> currencyNames, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
