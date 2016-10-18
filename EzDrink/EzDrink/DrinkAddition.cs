using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class DrinkAddition
    {
        private string _name;
        private int _price;

        //加料料名及價錢
        public DrinkAddition (string name, int price)
        {
            _name = name;
            _price = price;
        }

        //取得加料名
        public string GetAdditionName()
        {
            return(_name);
        }
        
        //取得加料價錢
        public int GetAdditionPrice()
        {
            return (_price);
        }
    }
}
