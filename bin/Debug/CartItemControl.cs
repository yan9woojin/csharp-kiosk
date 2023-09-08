using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kiosk
{
    [Serializable]
    public partial class CartItemControl : UserControl
    {
        // 상품 이름
        public new string Name
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        // 상품 가격
        public int Price
        {
            get { return Util.GetPriceFromLabel(lblProductPrice.Text); }
            set { lblProductPrice.Text = Util.GetPriceText(value); }
        }

        // 상품 사이즈
        public string PSize
        {
            get { return lblSize.Text; }
            set { lblSize.Text = value; }
        }

        // 상품 컵
        public string Cup
        {
            get { return lblCup.Text; }
            set { lblCup.Text = value; }
        }

        // 상품 수량
        public int Quantity
        {
            get { return int.Parse(lblQuantity.Text); }
            set { lblQuantity.Text = value.ToString(); }
        }
        public Image ProductImage { get; set; }


        // 이벤트 델리게이트
        public delegate void delEvent(object sender, string eventType);
        public event delEvent HandleButtonClick;

        // 생성자 함수
        public CartItemControl(Product product)
        {
            InitializeComponent();

            Name = product.이름;
            PSize = product.사이즈;
            Cup = product.컵;
            Quantity = product.수량;
            ProductImage = Util.GetImage(product.이미지);

            switch (product.사이즈)
            {
                case "Grande":
                    Price = product.가격 + 500;
                    break;
                case "Venti":
                    Price = product.가격 + 1000;
                    break;
                default:
                    Price = product.가격;
                    break;
            }
        }

        // 버튼을 클릭하면 처리하는 함수
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string eventType = string.Empty;

            switch (button.Name)
            {
                case "btnIncrease":
                    eventType = "INCREASE";
                    break;
                case "btnDecrease":
                    eventType = "DECREASE";
                    break;
                case "btnRemove":
                    eventType = "REMOVE";
                    break;
            }

            HandleButtonClick(this, eventType);
        }

        // 컨트롤에 테두리를 그리는 함수
        private void CartItem_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
    }
}
