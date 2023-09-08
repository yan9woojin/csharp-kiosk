using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class CartControl : UserControl
    {
        public List<CartItemControl> List { get; set; }
        public int Amount
        {
            get { return Util.GetPriceFromLabel(lblAmount.Text); }
            set { lblAmount.Text = Util.GetPriceText(value); }
        }

        public delOrder OpenOrder;

        // 생성자 함수
        public CartControl()
        {
            InitializeComponent();

            List = new List<CartItemControl>();
            Amount = 0;
        }

        // 상품을 클릭하면 카트에 해당 상품을 추가하는 함수
        public void AddItem(object sender, Product product)
        {
            btnOrder.Enabled = true;
            btnOrder.BackColor = MyColor.PrimaryColor;

            // 카트에 해당 상품이 이미 있는 경우 상품의 수량을 하나 증가
            CartItemControl cartItem = List.Find(item => item.Name == product.이름 && item.PSize == product.사이즈 && item.Cup == product.컵);
            if (cartItem != null)
            {
                IncreaseQuantity(cartItem);
                return;
            }

            // 카트에 해당 상품이 없는 경우 상품 추가
            cartItem = new CartItemControl(product);
            cartItem.HandleButtonClick += HandleButtonClick;

            List.Add(cartItem);
            Amount += cartItem.Price * cartItem.Quantity;

            SuspendLayout();

            flpCartList.Controls.Add(cartItem);

            ResumeLayout();
        }

        // 상품에서 버튼을 클릭하면 발생하는 이벤트를 처리하는 함수
        public void HandleButtonClick(object sender, string eventType)
        {
            CartItemControl target = (CartItemControl)sender;
            CartItemControl cartItem = List.Find(item => item.Name == target.Name && item.PSize == target.PSize && item.Cup == target.Cup);

            switch (eventType)
            {
                case "INCREASE":
                    IncreaseQuantity(cartItem);
                    break;
                case "DECREASE":
                    DecreaseQuantity(cartItem);
                    break;
                case "REMOVE":
                    RemoveItem(cartItem);
                    break;
            }
        }

        public void Clear()
        {
            List = new List<CartItemControl>();
            Amount = 0;
            btnOrder.Enabled = false;

            SuspendLayout();

            flpCartList.Controls.Clear();

            ResumeLayout();
        }

        // 카트에서 해당 상품의 수량을 하나 증가시키는 함수
        private void IncreaseQuantity(CartItemControl item)
        {
            item.Quantity++;
            Amount += item.Price;
        }

        // 카트에서 해당 상품의 수량을 하나 감소시키는 함수
        private void DecreaseQuantity(CartItemControl item)
        {
            if (item.Quantity == 1)
            {
                RemoveItem(item);
                return;
            }

            item.Quantity--;
            Amount -= item.Price;
        }

        // 카트에서 해당 상품을 제거하는 함수
        private void RemoveItem(CartItemControl item)
        {
            List.Remove(item);
            Amount -= item.Price * item.Quantity;

            flpCartList.SuspendLayout();

            flpCartList.Controls.Remove(item);

            flpCartList.ResumeLayout();

            if (List.Count == 0)
            {
                btnOrder.Enabled = false;
                btnOrder.BackColor = Color.LightGray;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenOrder(sender, List);
        }
    }
}
