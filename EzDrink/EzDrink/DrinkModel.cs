using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EzDrink
{
    public class DrinkModel
    {
        List<Drink> _drink = new List<Drink>();
        List<DrinkAddition> _drinkAddition = new List<DrinkAddition>();
        List<Order> _order = new List<Order>();
        List<List<Order>> _orderList = new List<List<Order>>();

        //初始飲料項目價錢
        const string GREEN_TEA_NAME = "茉莉綠茶";
        const int GREEN_TEA_PRICE = 20;
        Drink _greenTea = new Drink(GREEN_TEA_NAME, GREEN_TEA_PRICE);

        const string BLACK_TEA_NAME = "阿薩姆紅茶";
        const int BLACK_TEA_PRICE = 25;
        Drink _blackTea = new Drink(BLACK_TEA_NAME, BLACK_TEA_PRICE);
        
        const string MOUNTAIN_TEA_NAME = "高山青茶";
        const int MOUNTAIN_TEA_PRICE = 40;
        Drink _mountainTea = new Drink(MOUNTAIN_TEA_NAME, MOUNTAIN_TEA_PRICE);
        
        const string IRON_TEA_NAME = "鐵觀音";
        const int IRON_TEA_PRICE = 50;
        Drink _ironTea = new Drink(IRON_TEA_NAME, IRON_TEA_PRICE);

        const string LONG_TEA_NAME = "烏龍青茶";
        const int LONG_TEA_PRICE = 30;
        Drink _longTea = new Drink(LONG_TEA_NAME, LONG_TEA_PRICE);

        const string PEARL_NAME = "珍珠";
        const int PEARL_PRICE = 5;
        DrinkAddition _pearl = new DrinkAddition(PEARL_NAME, PEARL_PRICE);
        const string COCONUT_NAME = "椰果";
        const int COCONUT_PRICE = 5;
        DrinkAddition _coconut = new DrinkAddition(COCONUT_NAME, COCONUT_PRICE);
        const string MESONA_NAME = "仙草";
        const int MESONA_PRICE = 10;
        DrinkAddition _mesona = new DrinkAddition(MESONA_NAME, MESONA_PRICE);
        const string PUDDING_NAME = "布丁";
        const int PUDDING_PRICE = 10;
        DrinkAddition _pudding = new DrinkAddition(PUDDING_NAME, PUDDING_PRICE);

        //設定甜度及溫度字串
        const string NORMAL_SUGAR = "正常";
        const string HALF_SUGAR = "半糖";
        const string LESS_SUGAR = "微糖";
        const string NO_SUGAR = "無糖";
        const string NORMAL_ICE = "正常";
        const string HOT = "溫熱";
        const string LESS_ICE = "少冰";
        const string NO_ICE = "去冰";

        //初始化飲料項目
        public void InitializeDrinkItem()
        {
            _drink.Add(_greenTea);
            _drink.Add(_blackTea);
            _drink.Add(_mountainTea);
            _drink.Add(_ironTea);
            _drink.Add(_longTea);
        }

        //初始化加料項目
        public void InitializeAdditionItem()
        {
            _drinkAddition.Add(_pearl);
            _drinkAddition.Add(_coconut);
            _drinkAddition.Add(_mesona);
            _drinkAddition.Add(_pudding);
        }

        //取得飲料價錢
        public int GetOrderDrinkTotalPrice(int index)
        {
            return (_order[index].GetDrinkTotalPrice());
        }

        //取得飲料名稱
        public string GetDrinkItemName(int index)
        {
            return (_drink[index].GetName());
        }

        //取得飲料價錢
        public int GetDrinkItemPrice(int index)
        {
            return (_drink[index].GetPrice());
        }

        //取得加料名稱
        public string GetDrinkAdditionItemName(int item)
        {
            return (_drinkAddition[item].GetAdditionName());
        }

        //取得加料價錢
        public int GetDrinkAdditionItemPrice(int item)
        {
            return (_drinkAddition[item].GetAdditionPrice());
        }

        //新增飲料到訂單
        public void AddNewDrinkInOrder(int index)
        {
            _order.Add(new Order (_drink[index]));
        }

        //從訂單刪除飲料
        public void DeleteOrderDrinkItem(int index)
        {
            _order.RemoveAt(index);
        }

        //加料到飲料
        public void AddAdditionInDrink(int orderIndex, int additionIndex)
        {
            _order[orderIndex].AddAddition(_drinkAddition[additionIndex]);
        }

        //調整糖度
        public void AdjustSugar(int index, Sugar sugar)
        {
            _order[index].SetSugar(sugar);
        }

        //調整溫度
        public void AdjustTemperature(int index, Temperature temperature)
        {
            _order[index].SetTemperature(temperature);
        }

        //取得訂單項目數量
        public int GetOrderSize()
        {
            return (_order.Count());
        }

        //取得糖度文字
        public string GetSugarText(Sugar sugar)
        {
            switch (sugar)
            {
                case Sugar.NormalSugar:
                    return (NORMAL_SUGAR);
                case Sugar.HalfSugar:
                    return (HALF_SUGAR);
                case Sugar.LessSugar:
                    return (LESS_SUGAR);
                default:
                    return (NO_SUGAR);
            }

        }

        //取得溫度文字
        public string GetTemperatureText(Temperature temperature)
        {
            switch (temperature)
            {
                case Temperature.NormalIce:
                    return (NORMAL_ICE);
                case Temperature.Hot:
                    return (HOT);
                case Temperature.LessIce:
                    return (LESS_ICE);
                default:
                    return (NO_ICE);
            }
        }

        //結帳把訂單存入訂單清單並清除訂單view和跟訂單內容
        public void CheckOut()
        {
            _orderList.Add(_order);
            _order.Clear();
        }

        //計算總價
        public int CalculateTotalPrice()
        {
            int sum = 0;
            for (int i = 0; i < GetOrderSize(); i++)
            {
                sum += _order[i].GetDrinkTotalPrice();
            }
            return sum;
        }
    }
}