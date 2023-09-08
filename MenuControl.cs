using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class MenuControl : UserControl
    {
        private Menu menu;
        private Button prevBtn;

        public delEvent OpenOption;
        public delEvent AddToCart;

        // 생성자 함수
        public MenuControl()
        {
            InitializeComponent();

            string menuData = File.ReadAllText(@"./Data/menu.json");
            menu = JsonSerializer.Deserialize<Menu>(menuData);

        }

        // 메뉴 컨트롤이 로드될 때 실행되는 함수
        private void MenuControl_Load(object sender, EventArgs e)
        {
            BtnCategory_Click(btnDrink, e);
        }

        // 카테고리에 해당하는 상품을 출력하는 함수
        private void Paint_Menu(List<Product> productList, bool hasOption = true)
        {
            SuspendLayout();

            flpProductList.Controls.Clear();

            foreach (var product in productList)
            {
                ProductControl productControl = new ProductControl(product);

                if (hasOption) productControl.HandleClick += OpenOption;
                else productControl.HandleClick += AddToCart;

                flpProductList.Controls.Add(productControl);
            }

            ResumeLayout();
        }

        // 카테고리 버튼을 클릭했을 때 실행되는 함수
        private void BtnCategory_Click(object sender, EventArgs e)
        {
            // 이전에 클릭한 버튼이 있으면 해당 버튼의 배경색과 글자색을 원래대로 되돌린다.
            if (prevBtn != null)
            {
                prevBtn.BackColor = Color.White;
                prevBtn.ForeColor = Color.Black;
            }

            // 클릭한 메뉴 버튼의 배경색과 글자색을 바꾼다.
            Button button = (Button)sender;

            button.BackColor = MyColor.PrimaryColor;
            button.ForeColor = Color.White;

            prevBtn = button;

            // 클릭한 메뉴의 상품을 출력한다.
            switch (button.Text)
            {
                case "음료":
                    Paint_Menu(menu.음료);
                    break;
                case "푸드":
                    Paint_Menu(menu.푸드, false);
                    break;
            }
        }

        // 카테고리 버튼에 마우스가 들어가면 버튼의 색상을 변경하는 함수
        private void BtnCategory_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            button.BackColor = MyColor.PrimaryColor;
            button.ForeColor = Color.White;
        }

        // 카테고리 버튼에서 마우스가 떠나면 버튼의 색상을 변경하는 함수
        private void BtnCategory_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (prevBtn != button)
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
            }
        }
    }
}
