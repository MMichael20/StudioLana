using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    class FunctionService
    {
        public FunctionService()
        {

        }
        public DataSet GetUserById(int x)
        {
            UserService us = new UserService();
            return us.GetUserById(x);
        }
        public DataSet GetCity(int x)
        {
            CityService cs = new CityService();
            return cs.GetCity(x);
        }
        public DataSet GetId(string x)
        {
            CityService cs = new CityService();
            return cs.GetId(x);
        }
        public DataSet HighestUser()
        {
            UserService us = new UserService();
            return us.HighestUser();
        }
        public void InsertUser(User user)
        {
            UserService us = new UserService();
            us.InsertUser(user);
        }
        public DataSet GetOrdersById(int x)
        {
            OrderService os = new OrderService();
            return os.GetOrdersById(x);
        }
        public DataSet GetOrders(int x)
        {
            OrderService os = new OrderService();
            return os.GetOrdersById(x);
        }
        public DataSet GetReadyOrders(int x)
        {
            OrderService os = new OrderService();
            return os.GetFinishById(x);
        }
        public DataSet GetDebt(int x)
        {
            UserService us = new UserService();
            return us.GetDebt(x);
        }
        public void UpdateUser(User user)
        {
            UserService us = new UserService();
            us.UpdatetUser(user);
        }
        public DataSet GetUsers()
        {
            UserService us = new UserService();
            return us.GetUsers();
        }
        public DataSet GetUnfinished()
        {
            OrderService os = new OrderService();
            return os.GetUnfinished();
        }
        public DataSet GetUserDebts()
        {
            UserService us = new UserService();
            return us.GetUserDebts();
        }
        public DataSet GetClocks()
        {
            ClockService cs = new ClockService();
            return cs.GetClocks();
        }
        public DataSet GetClocksByMonth(int year, int month, string name)
        {
            ClockService cs = new ClockService();
            return cs.GetClocksByMonth(year, month, name);
        }
        public DataSet GetClocksByYear(int year, string name)
        {
            ClockService cs = new ClockService();
            return cs.GetClocksByYear(year, name);
        }
        public void SetCabin(List<int> ids, string cabin)
        {
            OrderService os = new OrderService();
            os.SetCabin(ids, cabin);
        }
        public void UpdateStatus(List<int> ids, string status)
        {
            OrderService os = new OrderService();
            os.UpdateStatus(ids, status);
        }
        public void Deliver(List<int> ids)
        {
            OrderService os = new OrderService();
            os.Deliver(ids);
        }
        public DataSet GetOrderPrint(int id)
        {
            OrderService os = new OrderService();
            return os.GetOrderPrint(id);
        }
        public DataSet GetOrderPrintByIds(List<int> ids)
        {
            OrderService os = new OrderService();
            return os.GetOrderPrintByIds(ids);
        }
        public DataSet ShopList()
        {
            ShopService cs = new ShopService();
            return cs.ShopList();
        }
        public void NewShop(Shop l)
        {
            ShopService cs = new ShopService();
            cs.NewShop(l);
        }
        public DataSet GetItemById(int id)
        {
            ItemService us = new ItemService();
            return us.GetItemById(id);
        }
        public DataSet GetItemPriceById(int itemId)
        {
            ItemService us = new ItemService();
            return us.GetItemPriceById(itemId);
        }
        public DataSet GetColorById(int x)
        {
            ColorService us = new ColorService();
            return us.GetColorById(x);
        }
        public DataSet GetColorByName(string name)
        {
            ColorService us = new ColorService();
            return us.GetColorByName(name);
        }
        public void NewOrder(List<Order> orders)
        {
            OrderService os = new OrderService();
            os.NewOrder(orders);
        }
        public void SetDebt(int id, int debt)
        {
            UserService us = new UserService();
            us.SetDebt(id, debt);
        }
        public DataSet GetItems()
        {
            ItemService os = new ItemService();
            return os.GetItems();
        }
        public void NewItem(Item item)
        {
            ItemService os = new ItemService();
            os.NewItem(item);
        }
        public void EditItem(Item item)
        {
            ItemService os = new ItemService();
            os.EditItem(item);
        }
        public DataSet GetAllPrices()
        {
            CheckService os = new CheckService();
            return os.GetAllPrices();
        }
        //public void UpIndex(ComboBox box)
        //{
        //    box.SelectedIndex = (box.SelectedIndex + 1) % box.Items.Count;
        //}
        public void isBought(List<int> ids)
        {
            ShopService os = new ShopService();
            os.isBought(ids);
        }
        public void SortChecks()
        {
            CheckService cs = new CheckService();
            cs.SortChecks();
        }

    }
}
