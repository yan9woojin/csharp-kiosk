using System.Collections.Generic;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class KioskForm : Form
    {
        private CartControl cart;
        private OptionControl option;
        private MenuControl menu;
        private OrderControl order;

        public KioskForm()
        {
            InitializeComponent();
        }

        private void KioskForm_Load(object sender, System.EventArgs e)
        {
            SuspendLayout();

            cart = new CartControl() { Dock = DockStyle.Fill };
            cart.OpenOrder += HandleOpenOrder;

            option = new OptionControl() { Dock = DockStyle.Fill };
            option.Close += HandleClose;
            option.AddToCart += cart.AddItem;

            menu = new MenuControl() { Dock = DockStyle.Fill };
            menu.OpenOption += HandleOpenOption;
            menu.AddToCart += cart.AddItem;

            layoutMain.Controls.Add(menu);
            layoutMain.Controls.Add(cart);

            order = new OrderControl() { Dock = DockStyle.Fill };
            order.Close += HandleCloseOrder;
            order.Reset += HandleReset;

            ResumeLayout();
        }

        private void HandleOpenOrder(object sender, List<CartItemControl> orderList)
        {
            SuspendLayout();

            layoutMain.Controls.Remove(menu);
            layoutMain.Controls.Remove(cart);

            order.Set(orderList);

            layoutMain.Controls.Add(order);
            layoutMain.SetRowSpan(order, 3);

            ResumeLayout();
        }

        public void HandleCloseOrder(object sender)
        {
            Button button = (Button)sender;

            SuspendLayout();

            layoutMain.Controls.Remove(order);

            layoutMain.Controls.Add(menu);

            if (button.Text == "결제하기")
            {
                cart.Clear();
            }

            layoutMain.Controls.Add(cart);

            ResumeLayout();
        }

        public void HandleOpenOption(object sender, Product product)
        {
            SuspendLayout();

            option.Initialize(product);
            layoutMain.Controls.Remove(menu);
            layoutMain.Controls.Remove(cart);
            layoutMain.Controls.Add(option);
            layoutMain.SetRowSpan(option, 3);

            ResumeLayout();
        }

        public void HandleClose(object sender, Product product)
        {
            SuspendLayout();

            layoutMain.Controls.Remove(option);
            layoutMain.Controls.Add(menu, 0, 1);
            layoutMain.Controls.Add(cart, 0, 2);

            ResumeLayout();
        }

        public void HandleReset(object sender)
        {
            SuspendLayout();

            layoutMain.Controls.Remove(order);

            layoutMain.Controls.Add(menu);

            cart.Clear();

            layoutMain.Controls.Add(cart);

            ResumeLayout();
        }
    }
}
