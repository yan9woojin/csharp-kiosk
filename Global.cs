using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Kiosk
{
    internal class Global
    {
    }

    public class Menu
    {
        public List<Product> 음료 { get; set; }
        public List<Product> 푸드 { get; set; }
    }

    public class Product
    {
        public string 이름 { get; set; }
        public int 가격 { get; set; }
        public string 이미지 { get; set; }
        public int 수량 { get; set; } = 1;
        public string 사이즈 { get; set; } = string.Empty;
        public string 컵 { get; set; } = string.Empty;

        public Product() { }
        public Product(Product product, int quantity, string size, string cup)
        {
            이름 = product.이름;
            가격 = product.가격;
            이미지 = product.이미지;
            수량 = quantity;
            사이즈 = size;
            컵 = cup;
        }
    }

    public class MyColor
    {
        public static Color PrimaryColor = Color.FromArgb(1, 113, 67);
    }

    public class Util
    {
        public static int GetPriceFromLabel(string label)
        {
            return int.Parse(label.Replace(",", "").Replace("원", ""));
        }

        public static string GetPriceText(int price)
        {
            return $"{price:N0}원";
        }

        public static Image GetImage(string imageSrc)
        {
            return Image.FromFile($@"./Resources/{imageSrc}");
        }
    }

    public delegate void delEvent(object sender, Product product);
    public delegate void delOrder(object sender, List<CartItemControl> orderList);
}