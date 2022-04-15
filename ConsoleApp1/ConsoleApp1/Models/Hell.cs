using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Hell:Product
    {
        public Hell(double saleprice, double cosprice):base(saleprice,cosprice)
        {

        }

        public override void ShowEarn()
        {
            double Earn = _salePrice - _costPrice;
            Console.WriteLine($"satisQiymeti budur{_salePrice} ,alis qiymeti budur{_costPrice} qazanda budur{Earn}");
            base.ShowEarn();
        }

    }
}
