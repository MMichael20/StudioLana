using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

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
        public int HighestUser()
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
        public Dictionary<string, decimal> OrderMonthReport(int month, int year)
        {
            OrderService os = new OrderService();
            return os.OrderMonthReport(month, year);
        }
        public DataSet GetUserDebts()
        {
            UserService us = new UserService();
            return us.GetUserDebts();
        }
        public OleDbDataReader GetAllUsersPhones()
        {
            UserService us = new UserService();
            return us.GetAllUsersPhones();
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
        public DataSet GetAllChecks()
        {
            CheckService cs = new CheckService();
            return cs.GetAllChecks();
        }
        public DataSet GetAllOrdersById(int i)
        {
            //UserService us = new UserService();
            //return us.GetUsers();
            OrderService os = new OrderService();
            return os.GetAllOrdersById(i);
        }
        public DataSet GetAllSent()
        {
            //UserService us = new UserService();
            //return us.GetUsers();
            OrderService os = new OrderService();
            return os.GetAllSent();
        }
        public DataSet GetAllSentById(int id)
        {
            //UserService us = new UserService();
            //return us.GetUsers();
            OrderService os = new OrderService();
            return os.GetAllSentById(id);
        }
        public DataSet GetAllUnpaidOrdersById(int id)
        {
            OrderService os = new OrderService();
            return os.GetAllUnpaidOrdersById(id);
        }
        public void CloseDebt(int id, int amount)
        {
            OrderService os = new OrderService();
            os.CloseDebt(id, amount);
        }
        public void UpdateFull(int id)
        {
            OrderService os = new OrderService();
            os.UpdateFull(id);
        }
        public void PayForOrders(int id, int amount)
        {
            OrderService os = new OrderService();
            os.PayForOrders(id, amount);
        }
        public void NewCheck(Check p)
        {
            CheckService cs = new CheckService();
            cs.NewCheck(p);
        }
        public void Pay(List<int[]> listId)
        {
            OrderService os = new OrderService();
            os.Pay(listId);
        }
        public DataSet GetAllUnfinshedOrdersById(int id)
        {
            OrderService os = new OrderService();
            return os.GetAllUnfinishedOrdersById(id);
        }
        public int HighestInvoice()
        {
            InvoiceService os = new InvoiceService();
            return os.HighestInvoice();
        }
        public List<int> ListOfInvoices(List<int> ids)
        {
            OrderService os = new OrderService();
            return os.ListOfInvoices(ids);
        }
        public int OrdersPriceSum(List<int> ids)
        {
            OrderService os = new OrderService();
            return os.OrdersPriceSum(ids);
        }
        public void NewInvoice(Invoice invoice)
        {
            InvoiceService os = new InvoiceService();
            os.NewInvoice(invoice);
        }
        public void UpdateOrdersInvoice(List<int> ids, int invoiceId)
        {
            OrderService os = new OrderService();
            os.UpdateOrdersInvoice(ids, invoiceId);
        }
        public DataSet NeedsReceipt(int id)
        {
            OrderService os = new OrderService();
            return os.NeedsReceipt(id);
        }
        public void SetOrdersCheck(List<int> ids, int CheckId)
        {
            OrderService os = new OrderService();
            os.SetOrdersCheck(ids, CheckId);
        }
        public int HighestCheck()
        {
            CheckService cs = new CheckService();
            return cs.HighestCheck();
        }
        public int HighestReceipt()
        {
            ReceiptService cs = new ReceiptService();
            return cs.HighestReceipt();
        }
        public void NewReceipt(Receipt i)
        {
            ReceiptService cs = new ReceiptService();
            cs.NewReceipt(i);
        }
        public DataSet GetAllInvoicelessOrdersById(int id)
        {
            OrderService os = new OrderService();
            return os.GetAllInvoicelessOrdersById(id);
        }
        public DataSet GetCheckPrint(int check)
        {
            OrderService os = new OrderService();
            return os.GetCheckPrint(check);
        }
        public DataSet GetCheckById(int check)
        {
            CheckService cs = new CheckService();
            return cs.GetCheckById(check);
        }
        public DataSet GetReceiptById(int id)
        {
            ReceiptService cs = new ReceiptService();
            return cs.GetReceiptById(id);
        }
        public DataSet GetInvoiceById(int id)
        {
            InvoiceService cs = new InvoiceService();
            return cs.GetInvoiceById(id);
        }
        public DataSet GetInvoicePrint(int invoice)
        {
            OrderService cs = new OrderService();
            return cs.GetInvoicePrint(invoice);
        }
        public void SetInvoicePrinted(int id)
        {
            InvoiceService os = new InvoiceService();
            os.SetInvoicePrinted(id);
        }
        public void SetReceiptPrinted(int id)
        {
            ReceiptService os = new ReceiptService();
            os.SetReceiptPrinted(id);
        }
        public void SetCheckPrinted(int id)
        {
            CheckService cs = new CheckService();
            cs.SetCheckPrinted(id);
        }
        public DataSet GetAllReceiptsByUserId(int id)
        {
            ReceiptService os = new ReceiptService();
            return os.GetAllReceiptsByUserId(id);
        }
        public DataSet GetReceiptByIdTable(int id)
        {
            ReceiptService os = new ReceiptService();
            return os.GetReceiptByIdTable(id);
        }
        public DataSet GetAllInvoicesByUserId(int id)
        {
            InvoiceService os = new InvoiceService();
            return os.GetAllInvoicesByUserId(id);
        }
        public DataSet GetAllChecksByUserId(int id)
        {
            CheckService cs = new CheckService();
            return cs.GetAllChecksByUserId(id);
        }
        public DataSet GetInvoicesByIdTable(int id)
        {
            InvoiceService cs = new InvoiceService();
            return cs.GetAllInvoicesByIdTable(id);
        }
        public bool isRegisterOpen()
        {
            RegisterService os = new RegisterService();
            return os.isRegisterOpen();
        }
        public void OpenRegister(int amount)
        {
            RegisterService os = new RegisterService();
            os.OpenRegister(amount);
        }
        public int SuggestOpen()
        {
            RegisterService os = new RegisterService();
            return os.SuggestOpen();
        }
        public Register GetTodayRegister()
        {
            RegisterService os = new RegisterService();
            return os.GetTodayRegister();
        }
        public void AddMoney(int amount, string type)
        {
            RegisterService os = new RegisterService();
            os.AddMoney(amount, type);
        }

    }
}
