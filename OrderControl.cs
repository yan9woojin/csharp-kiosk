using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class OrderControl : UserControl
    {
        private List<CartItemControl> orderList;
        private string payment = string.Empty;
        private Button lastPayBtn;
        public int TotalPrice
        {
            get { return Util.GetPriceFromLabel(lblTotalPrice.Text); }
            set { lblTotalPrice.Text = Util.GetPriceText(value); }
        }

        public delegate void del(object sender);
        public del Close;
        public del Reset;

        public OrderControl()
        {
            InitializeComponent();
        }

        public void Set(List<CartItemControl> orderList)
        {
            ResetAll();

            this.orderList = orderList;

            SuspendLayout();

            foreach (var cartItem in orderList)
            {
                int quantitiy = cartItem.Quantity;
                int price = cartItem.Price;
                TotalPrice += quantitiy * price;
                OrderItemControl orderItem = new OrderItemControl(cartItem);
                flpOrderList.Controls.Add(orderItem);
            }

            ResumeLayout();
        }

        private void btnPayOption_Click(object sender, EventArgs e)
        {
            if (lastPayBtn != null)
            {
                ReturnBtnStyle(lastPayBtn);
            }

            Button button = (Button)sender;
            payment = button.Text;

            ChangeBtnStyle(button);
            lastPayBtn = button;

            if (payment != string.Empty)
            {
                btnPay.Enabled = true;
                ChangeBtnStyle(btnPay);
            }
        }

        private void ResetAll()
        {
            if (lastPayBtn != null)
            {
                ReturnBtnStyle(lastPayBtn);
            }
            btnPay.Enabled = false;
            payment = string.Empty;
            lastPayBtn = null;
            TotalPrice = 0;
            flpOrderList.Controls.Clear();
        }

        private void ReturnBtnStyle(Button button)
        {
            button.FlatAppearance.BorderColor = Color.LightGray;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private void ChangeBtnStyle(Button button)
        {
            button.FlatAppearance.BorderColor = Color.FromArgb(1, 113, 67);
            button.BackColor = Color.FromArgb(1, 113, 67);
            button.ForeColor = Color.White;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close(sender);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string orderData = File.ReadAllText(@"./Data/order.json");
            List<OrderData> orders = JsonSerializer.Deserialize<List<OrderData>>(orderData);

            var order = new OrderData(payment, TotalPrice);

            foreach (var item in orderList)
            {
                order.주문내역.Add(new MenuData(item.Name, item.Quantity, item.PSize, item.Cup));
            }

            orders.Insert(0, order);

            var options = new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) };
            string json = JsonSerializer.Serialize(orders, options);

            File.WriteAllText(@"./Data/order.json", json);

            MessageBox.Show("주문이 접수되었습니다.");

            Reset(sender);
        }

        class OrderData
        {
            public string 주문시간 { get; set; }
            public string 결제수단 { get; set; }
            public int 결제금액 { get; set; }
            public List<MenuData> 주문내역 { get; set; }

            public OrderData() { }

            public OrderData(string payment, int totalPrice)
            {
                주문시간 = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                결제수단 = payment;
                결제금액 = totalPrice;
                주문내역 = new List<MenuData>();
            }
        }

        class MenuData
        {
            public string Name { get; set; }
            public int Quantity { get; set; }

            public string Size { get; set; }
            public string Cup { get; set; }

            public MenuData(string name, int quantity, string size, string cup)
            {
                Name = name;
                Quantity = quantity;
                Size = size;
                Cup = cup;
            }
        }
    }
}
