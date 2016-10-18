using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class PresentationModel
    {
        List <ButtonStatus> _buttonStatus = new List<ButtonStatus>();
        bool _totalCheckOutButtonStatus = false;
        const int PEARL_INDEX = 0;
        const int COCONUT_INDEX = 1;
        const int MESONA_INDEX = 2;
        const int PUDDING_INDEX = 3;
        const int SUGAR_INDEX = 4;
        const int TEMPERATURE_INDEX = 5;

        //改變結帳鈕狀態
        public void ChangeTotalCheckOutButton()
        {
            _totalCheckOutButtonStatus = true;
            for (int i = 0; i < _buttonStatus.Count; i++)
            {
                if ((_buttonStatus[i].IsCheckOutButtonStatus()) == false)
                {
                    _totalCheckOutButtonStatus = false;
 
                }
            }
        } 

        //新增新的飲料鈕狀表
        public void AddNewDrinkButtonStatus()
        {
            _buttonStatus.Add(new ButtonStatus());
        }

        //得到結帳鈕狀態
        public bool IsCheckTotalOutButton()
        {
            return (_totalCheckOutButtonStatus);
        }

        //得到加料鈕狀態
        public bool IsAdditionStatus(int index, int additionIndex)
        {
            switch (additionIndex)
            {
                case PEARL_INDEX:
                    return (_buttonStatus[index].IsPearlButtonStatus());
                case COCONUT_INDEX:
                    return (_buttonStatus[index].IsCoconutButtonStatus());
                case MESONA_INDEX:
                    return (_buttonStatus[index].IsMesonaButtonStatus());
                case PUDDING_INDEX:
                    return (_buttonStatus[index].IsPuddingButtonStatus());
                default:
                    return (true);
            }
        }

        //改變加料狀態
        public void ChangeAdditionStatus(int index, int additionIndex)
        {
            switch (additionIndex)
            {
                case PEARL_INDEX:
                    _buttonStatus[index].ChangePearlButtonStatus();
                    break;
                case COCONUT_INDEX:
                    _buttonStatus[index].ChangeCoconutButtonStatus();
                    break;
                case MESONA_INDEX:
                    _buttonStatus[index].ChangeMesonaButtonStatus();
                    break;
                case PUDDING_INDEX:
                    _buttonStatus[index].ChangePuddingButtonStatus();
                    break;
                case SUGAR_INDEX:
                    _buttonStatus[index].ChangeSugarButtonStatus();
                    break;
                case TEMPERATURE_INDEX:
                    _buttonStatus[index].ChangeTemperatureButtonStatus();
                    break;
            }
        }

        //刪除某個飲料按鈕狀態表
        public void DeleteButton(int index)
        {
            _buttonStatus.RemoveAt(index);
        }

        //刪除全部飲料按鈕狀態表
        public void DeleteAllButton()
        {
            _buttonStatus.Clear();
        }

        //計算加料狀態表有幾個
        public int GetCountButton()
        {
            return _buttonStatus.Count();
        }
    }
}
