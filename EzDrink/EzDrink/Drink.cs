using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EzDrink
{
    public class Drink
    {
        private string _name;
        private int _price;

        //初始值
        public Drink(string name, int price)
        {
            _name = name;
            _price = price;
        }

        //拿飲料的名稱
        public string GetName()
        {
            return (_name);
        }

        //拿飲料的價格
        public int GetPrice()
        {
            return (_price);
        }

        //新增飲料項目價錢到dataTable
        public void AddDrink(DataTable dataTable)
        {
            dataTable.Rows.Add(_name, _price);
        }
    }
}