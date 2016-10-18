using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    public partial class EzDrink : Form
    {
        DrinkModel _drink = new DrinkModel();
        PresentationModel _presentationModel = new PresentationModel();
        const int SIZE_OF_DRINK = 5;
        const int SIZE_OF_ADDITION = 4;
        const int ORDER_VIEW_COLUMN_OF_ADDITION = 4;
        const int ORDER_VIEW_COLUMN_OF_TEMPERATURE = 3;
        const int ORDER_VIEW_COLUMN_OF_SUGAR = 2;
        const int MESONA_INDEX = 2;
        const int PUDDING_INDEX = 3;
        const int SUGAR_INDEX = 4;
        const int TEMPERATURE_INDEX = 5;
        const string TOTAL_PRICE_TEXT = "總價:";
        public EzDrink()
        {
            InitializeComponent();
            _drink.InitializeDrinkItem();
            _drink.InitializeAdditionItem();
            const string SELECT_TEXT = "選擇";
 
            for (int i = 0; i < SIZE_OF_DRINK; i++)
            {
                _drinkView.Rows.Add(SELECT_TEXT, _drink.GetDrinkItemName(i), _drink.GetDrinkItemPrice(i));
            }
            for (int i = 0; i < SIZE_OF_ADDITION; i++)
            {
                _drinkAdditionView.Rows.Add(SELECT_TEXT, _drink.GetDrinkAdditionItemName(i), _drink.GetDrinkAdditionItemPrice(i));
            }
            _drink.CalculateTotalPrice();
            InitializeButton();
        }

        //離開
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //點擊菜單觸發事件
        private void ClickDrinkViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            //當按下選擇件時，將該列新增到_orderlist
            if (e.ColumnIndex == 0)
            {
                _drink.AddNewDrinkInOrder(e.RowIndex);
                _orderView.Rows.Add(_drink.GetDrinkItemName(e.RowIndex), _drink.GetDrinkItemPrice(e.RowIndex));
                _drink.CalculateTotalPrice();
                _presentationModel.AddNewDrinkButtonStatus();
            }
            InitializeButton();
        }

        //點訂單觸發
        private void ClickOrderViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            InitializeButton();
            _drinkAdditionView.Refresh();
            const int DELETE_BUTTON_COLUMN = 5;

            if (e.ColumnIndex == DELETE_BUTTON_COLUMN)
            {
                _drink.DeleteOrderDrinkItem(e.RowIndex);
                _orderView.Rows.RemoveAt(e.RowIndex);
                _drink.CalculateTotalPrice();
                _presentationModel.DeleteButton(e.RowIndex);
                _totalPriceLabel.Text = TOTAL_PRICE_TEXT + _drink.CalculateTotalPrice().ToString();
            }
            InitializeButton();
        }

        //加料觸發
        private void ClickDrinkAdditionViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            InitializeButton();
            if ((e.ColumnIndex == 0 && _drink.GetOrderSize() != 0) && ((DataGridViewDisableButtonCell)_drinkAdditionView.Rows[e.RowIndex].Cells[0]).Enabled == true)
            {
                _drink.AddAdditionInDrink(_orderView.CurrentRow.Index, e.RowIndex);
                if (_orderView.CurrentRow.Cells[ORDER_VIEW_COLUMN_OF_ADDITION].Value == null)
                {
                    _orderView.CurrentRow.Cells[ORDER_VIEW_COLUMN_OF_ADDITION].Value += _drinkAdditionView.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    _orderView.CurrentRow.Cells[ORDER_VIEW_COLUMN_OF_ADDITION].Value += "、" + _drinkAdditionView.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                _orderView.CurrentRow.Cells[1].Value = _drink.GetOrderDrinkTotalPrice(_orderView.CurrentRow.Index);
                _totalPriceLabel.Text = TOTAL_PRICE_TEXT + _drink.CalculateTotalPrice().ToString();
                _presentationModel.ChangeAdditionStatus(_orderView.CurrentRow.Index, e.RowIndex);
                ((DataGridViewDisableButtonCell)_drinkAdditionView.Rows[e.RowIndex].Cells[0]).Enabled = _presentationModel.IsAdditionStatus(_orderView.CurrentRow.Index, e.RowIndex);
            }
            InitializeButton();
        }

        //點正常糖觸發
        private void ClickNormalSugar(object sender, EventArgs e)
        {
            if (_drink.GetOrderSize() != 0)
            {
                _drink.AdjustSugar(_orderView.CurrentRow.Index, Sugar.NormalSugar);
                _orderView.CurrentRow.Cells[ORDER_VIEW_COLUMN_OF_SUGAR].Value = _drink.GetSugarText(Sugar.NormalSugar);
                _presentationModel.ChangeAdditionStatus(_orderView.CurrentRow.Index, SUGAR_INDEX);
                InitializeButton();
            }
        }

        //點半糖觸發
        private void ClickHalfSugar(object sender, EventArgs e)
        {
            if (_drink.GetOrderSize() != 0)
            {
                _drink.AdjustSugar(_orderView.CurrentRow.Index, Sugar.NormalSugar);
                _orderView.CurrentRow.Cells[ORDER_VIEW_COLUMN_OF_SUGAR].Value = _drink.GetSugarText(Sugar.HalfSugar);
                _presentationModel.ChangeAdditionStatus(_orderView.CurrentRow.Index, SUGAR_INDEX);
                InitializeButton();
            }

        }
    
        //點少糖觸發
        private void ClickLessSugar(object sender, EventArgs e)
        {
            if (_drink.GetOrderSize() != 0)
            {
                _drink.AdjustSugar(_orderView.CurrentRow.Index, Sugar.LessSugar);
                _orderView.CurrentRow.Cells[ORDER_VIEW_COLUMN_OF_SUGAR].Value = _drink.GetSugarText(Sugar.LessSugar);
                _presentationModel.ChangeAdditionStatus(_orderView.CurrentRow.Index, SUGAR_INDEX);
                InitializeButton();
            }
        }

        //點無糖觸發
        private void ClickNoSugar(object sender, EventArgs e)
        {
            if (_drink.GetOrderSize() != 0)
            {
                _drink.AdjustSugar(_orderView.CurrentRow.Index, Sugar.NoSugar);
                _orderView.CurrentRow.Cells[ORDER_VIEW_COLUMN_OF_SUGAR].Value = _drink.GetSugarText(Sugar.NoSugar);
                _presentationModel.ChangeAdditionStatus(_orderView.CurrentRow.Index, SUGAR_INDEX);
                InitializeButton();
            }
        }

        //點正常冰觸發
        private void ClickNormalIce(object sender, EventArgs e)
        {
            if (_drink.GetOrderSize() != 0)
            {
                _drink.AdjustTemperature(_orderView.CurrentRow.Index, Temperature.NormalIce);
                _orderView.CurrentRow.Cells[ORDER_VIEW_COLUMN_OF_TEMPERATURE].Value = _drink.GetTemperatureText(Temperature.NormalIce);
                _presentationModel.ChangeAdditionStatus(_orderView.CurrentRow.Index, TEMPERATURE_INDEX);
                InitializeButton();
            }
        }

        //點溫熱觸發
        private void ClickHot(object sender, EventArgs e)
        {
            if (_drink.GetOrderSize() != 0)
            {
                _drink.AdjustTemperature(_orderView.CurrentRow.Index, Temperature.Hot);
                _orderView.CurrentRow.Cells[ORDER_VIEW_COLUMN_OF_TEMPERATURE].Value = _drink.GetTemperatureText(Temperature.Hot);
                _presentationModel.ChangeAdditionStatus(_orderView.CurrentRow.Index, TEMPERATURE_INDEX);
                InitializeButton();
            }
        }

        //點少冰觸發
        private void ClickLessIce(object sender, EventArgs e)
        {
            if (_drink.GetOrderSize() != 0)
            {
                _drink.AdjustTemperature(_orderView.CurrentRow.Index, Temperature.LessIce);
                _orderView.CurrentRow.Cells[ORDER_VIEW_COLUMN_OF_TEMPERATURE].Value = _drink.GetTemperatureText(Temperature.LessIce);
                _presentationModel.ChangeAdditionStatus(_orderView.CurrentRow.Index, TEMPERATURE_INDEX);
                InitializeButton();
            }
        }

        //點去冰觸發
        private void ClickNoIce(object sender, EventArgs e)
        {
            if (_drink.GetOrderSize() != 0)
            {
                _drink.AdjustTemperature(_orderView.CurrentRow.Index, Temperature.NOIce);
                _orderView.CurrentRow.Cells[ORDER_VIEW_COLUMN_OF_TEMPERATURE].Value = _drink.GetTemperatureText(Temperature.NOIce);
                _presentationModel.ChangeAdditionStatus(_orderView.CurrentRow.Index, TEMPERATURE_INDEX);
                InitializeButton();
            }
        }

        //點結帳
        private void ClickCheckOutButton(object sender, EventArgs e)
        {
            _drink.CheckOut();
            _orderView.Rows.Clear();
            _presentationModel.DeleteAllButton();
            SetAllButton(false);
            _totalPriceLabel.Text = TOTAL_PRICE_TEXT + _drink.CalculateTotalPrice();
            InitializeButton();
        }

        //更新按鈕
        private void InitializeButton()
        {
            _presentationModel.ChangeTotalCheckOutButton();
            const int ADDITION_ITEM_NUMBER = 4;
            if (_presentationModel.GetCountButton() == 0)
            {
                for (int i = 0; i < ADDITION_ITEM_NUMBER; i++)
                {
                    ((DataGridViewDisableButtonCell)_drinkAdditionView.Rows[i].Cells[0]).Enabled = false;
                }
                SetAllButton(false);
                _checkOutButton.Enabled = false;
            }

            else
            {
                for (int i = 0; i < ADDITION_ITEM_NUMBER; i++)
                {
                   ((DataGridViewDisableButtonCell)_drinkAdditionView.Rows[i].Cells[0]).Enabled = _presentationModel.IsAdditionStatus(_orderView.CurrentCell.RowIndex, i);
                }
                SetAllButton(true);
                _checkOutButton.Enabled = _presentationModel.IsCheckTotalOutButton();
            }
            _drinkAdditionView.Refresh();
        }

        //更新訂單情況
        private void ClickOrderView(object sender, EventArgs e)
        {
            InitializeButton();
        }

        //設定全部的按鈕
        private void SetAllButton(bool enable)
        {
            _normalSugar.Enabled = enable;
            _halfSugar.Enabled = enable;
            _lessSugar.Enabled = enable;
            _noSugar.Enabled = enable;
            _normalIce.Enabled = enable;
            _hot.Enabled = enable;
            _lessIce.Enabled = enable;
            _noIce.Enabled = enable;
        }
    }
}