using System.Drawing;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class OrderItemControl : UserControl
    {
        public new string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }
        public string ProductSize
        {
            get { return lblSize.Text; }
            set { lblSize.Text = value; }
        }
        public string Cup
        {
            get { return lblCup.Text; }
            set { lblCup.Text = value; }
        }
        public int Quantity
        {
            get { return int.Parse(lblQuantity.Text.Replace("개", "")); }
            set { lblQuantity.Text = value.ToString() + "개"; }
        }
        public int TotalPrice
        {
            get { return Util.GetPriceFromLabel(lblTotalPrice.Text); }
            set { lblTotalPrice.Text = Util.GetPriceText(value); }
        }
        public Image ProductImage
        {
            get { return pbProductImage.Image; }
            set { pbProductImage.Image = value; }
        }
        public OrderItemControl(CartItemControl cartItem)
        {
            InitializeComponent();

            ProductName = cartItem.Name;
            ProductSize = cartItem.PSize;
            Cup = cartItem.Cup;
            Quantity = cartItem.Quantity;
            ProductImage = cartItem.ProductImage;
            TotalPrice = cartItem.Price * cartItem.Quantity;
        }

        private void OrderItem_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
    }
}
