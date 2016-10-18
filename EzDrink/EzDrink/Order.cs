using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EzDrink
{
    public class Order
    {
        private Drink _drink;
        private int _totalPrice;
        private Sugar _sugar;
        private Temperature _temperature;
        private List<DrinkAddition> _drinkAddition = new List<DrinkAddition>();

        //飲料格式
        public Order(Drink drink)
        {
            _drink = drink;
            _totalPrice = drink.GetPrice();
        }

        //加糖
        public void SetSugar(Sugar sugar)
        {
            _sugar = sugar;
        }

        //加溫度
        public void SetTemperature(Temperature temperature)
        {
            _temperature = temperature;
        }

        //加料
        public void AddAddition(DrinkAddition drinkAddition)
        {
            _drinkAddition.Add(drinkAddition);
            _totalPrice += drinkAddition.GetAdditionPrice();  
        }

        //取得飲料價錢
        public int GetDrinkTotalPrice()
        {
            return (_totalPrice);
        }
    }
}
