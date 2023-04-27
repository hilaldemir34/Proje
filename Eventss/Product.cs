using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventss
{
    public delegate void StockControl();
    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }
        public event StockControl StockControlEvent;
        public string StockName { get; set; }
        public int Stock
        {
            get
            {
                return _stock;

            }
            set
            {
                _stock = value;
                if(value<15&&StockControlEvent!=null)
                {
                    StockControlEvent();
                }
            }
        }
        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("Stock amount:{0}", Stock);
        }
    }
}
