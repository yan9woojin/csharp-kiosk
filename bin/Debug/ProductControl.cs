using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class ProductControl : UserControl
    {
        Product product;

        // 상품 이름
        public string 이름
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        // 상품 가격
        public int 가격
        {
            get { return Util.GetPriceFromLabel(lblProductPrice.Text); }
            set { lblProductPrice.Text = Util.GetPriceText(value); }
        }

        // 상품 이미지
        public Image 이미지
        {
            get { return pbProductImage.Image; }
            set { pbProductImage.Image = value; }
        }

        // 컨트롤을 클릭하면 실행될 함수
        public event delEvent HandleClick;

        public ProductControl(Product product)
        {
            InitializeComponent();

            this.product = product;
            이름 = product.이름;
            가격 = product.가격;
            이미지 = Util.GetImage(product.이미지);
        }

        // 컨트롤을 클릭하면 실행되는 함수
        // 음료를 클릭하면 옵션창을 열고, 푸드를 클릭하면 카트에 담긴다.
        private void ProductControl_Click(object sender, EventArgs e)
        {
            HandleClick?.Invoke(this, product);
        }

        // 컨트롤에 테두리를 그리는 함수
        private void ProductControl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        // 컨트롤에 마우스가 들어오면 컨트롤의 배경색을 변경하는 함수
        private void ProductControl_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }

        // 컨트롤에서 마우스가 떠나면 컨트롤의 배경색을 변경하는 함수
        private void ProductItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
