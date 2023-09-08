using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class OptionControl : UserControl
    {
        private Product Product { get; set; }
        private Button BtnSize { get; set; }
        private Button BtnCup { get; set; }
        public string ProductSize { get; set; }
        public string Cup { get; set; }
        public int Quantity
        {
            get { return int.Parse(lblAmount.Text); }
            set { lblAmount.Text = value.ToString(); }
        }

        public OptionControl()
        {
            InitializeComponent();
        }

        public void Initialize(Product product)
        {
            Product = product;
            BtnSize = null;
            BtnCup = null;
            ProductSize = "Tall";
            Cup = string.Empty;
            Quantity = product.수량;

            btnMinus.Enabled = false;
            btnMinus.BackColor = Color.WhiteSmoke;
            btnMinus.ForeColor = Color.White;
            btnAdd.Enabled = false;
            btnAdd.BackColor = Color.LightGray;

            lblProductName.Text = product.이름;
            lblProductPrice.Text = Util.GetPriceText(product.가격);
            pbProductImage.Image = Util.GetImage(product.이미지);

            btnSize_Click(btnTall, new EventArgs());
        }

        public event delEvent Close;
        public event delEvent AddToCart;

        public void HandleClose(object sender, Product product)
        {
            Close(this, product);
        }

        public void HandleAddToCart(object sender, Product product)
        {

            Close(this, product);

            Product newProduct = new Product(product, Quantity, ProductSize, Cup);

            AddToCart(this, newProduct);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (BtnSize != null)
            {
                ReturnBtnStyle(BtnSize);
            }
            if (BtnCup != null)
            {
                ReturnBtnStyle(BtnCup);
            }
            HandleClose(sender, Product);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReturnBtnStyle(BtnSize);
            ReturnBtnStyle(BtnCup);
            HandleAddToCart(sender, Product);
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            if (BtnSize != null)
            {
                ReturnBtnStyle(BtnSize);
            }

            Button button = (Button)sender;
            ChangeBtnStyle(button);
            BtnSize = button;

            int idx = button.Text.IndexOf("+");
            ProductSize = button.Text.Substring(0, idx - 4);
            SetAmountPrice();

            if (ProductSize != string.Empty && Cup != string.Empty)
            {
                btnAdd.Enabled = true;
                ChangeBtnStyle(btnAdd);
            }
        }

        private void btnCup_Click(object sender, EventArgs e)
        {
            if (BtnCup != null)
            {
                ReturnBtnStyle(BtnCup);
            }

            Button button = (Button)sender;
            ChangeBtnStyle(button);
            BtnCup = button;

            Cup = button.Text;
            SetAmountPrice();

            if (ProductSize != string.Empty && Cup != string.Empty)
            {
                btnAdd.Enabled = true;
                ChangeBtnStyle(btnAdd);
            }
        }

        private void ReturnBtnStyle(Button button)
        {
            button.FlatAppearance.BorderColor = Color.LightGray;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private void ChangeBtnStyle(Button button)
        {
            button.FlatAppearance.BorderColor = MyColor.PrimaryColor;
            button.BackColor = MyColor.PrimaryColor;
            button.ForeColor = Color.White;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Quantity--;
            SetAmountPrice();

            if (Quantity == 1)
            {
                btnMinus.Enabled = false;
                btnMinus.BackColor = Color.WhiteSmoke;
                btnMinus.ForeColor = Color.White;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Quantity++;
            SetAmountPrice();

            if (!btnMinus.Enabled)
            {
                btnMinus.Enabled = true;
                btnMinus.BackColor = MyColor.PrimaryColor;
                btnMinus.ForeColor = Color.White;
            }
        }

        private void SetAmountPrice()
        {
            int price = Product.가격;

            switch (ProductSize)
            {
                case "Tall":
                    price += 0;
                    break;
                case "Grande":
                    price += 500;
                    break;
                case "Venti":
                    price += 1000;
                    break;
            }

            lblAmountPrice.Text = Util.GetPriceText(price * Quantity);
        }
    }
}
