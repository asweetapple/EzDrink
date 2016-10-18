using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    class ButtonStatus
    {
        private bool _pearlButtonStatus = true;
        private bool _coconutButtonStatus = true;
        private bool _mesonaButtonStatus = true;
        private bool _puddingButtonStatus = true;
        private bool _sugarButtonStatus = true;
        private bool _temperatureButtonStatus = true;
        private bool _checkOutButtonStatus = false;
        
        //取得珍珠是否加料狀態
        public bool IsPearlButtonStatus()
        {
            return (_pearlButtonStatus);
        }

        //取得椰果是否加料狀態
        public bool IsCoconutButtonStatus()
        {
            return (_coconutButtonStatus);
        }

        //取得仙草是否加料狀態
        public bool IsMesonaButtonStatus()
        {
            return (_mesonaButtonStatus);
        }

        //取得布丁是否加料狀態
        public bool IsPuddingButtonStatus()
        {
            return (_puddingButtonStatus);
        }

        //取得該項否可以結帳狀態
        public bool IsCheckOutButtonStatus()
        {
            return (_checkOutButtonStatus);
        }

        //取得溫度是否選擇狀態
        public bool IsTemperatureButtonStatus()
        {
            return (_temperatureButtonStatus);
        }

        //取得甜度是否選擇狀態
        public bool IsSugarButtonStatus()
        {
            return (_sugarButtonStatus);
        }

        //變更珍珠按鈕狀態值
        public void ChangePearlButtonStatus()
        {
            _pearlButtonStatus = false;
        }

        //變更椰果按鈕狀態值
        public void ChangeCoconutButtonStatus()
        {
            _coconutButtonStatus = false;
        }

        //變更仙草按鈕狀態值
        public void ChangeMesonaButtonStatus()
        {
            _mesonaButtonStatus = false;
        }

        //變更布丁按鈕狀態值
        public void ChangePuddingButtonStatus()
        {
            _puddingButtonStatus = false;
        }

        //變更溫度是否選擇
        public void ChangeTemperatureButtonStatus()
        {
            _temperatureButtonStatus = false;
            ChangeCheckOutButtonStatus();
        }

        //變更甜度按是否選擇
        public void ChangeSugarButtonStatus()
        {
            _sugarButtonStatus = false;
            ChangeCheckOutButtonStatus();
        }

        //變更該項飲料是否可以結帳狀態
        public void ChangeCheckOutButtonStatus()
        {
            if ((_sugarButtonStatus == false) && (_temperatureButtonStatus == false))
            {
                _checkOutButtonStatus = true;
            }
        }
    }
}
