using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Product
    {
        protected double _salePrice;
        protected double _costPrice;
        public double SalePrice {
            get => _salePrice;
            set
            {
                _salePrice = value;
            }

        }
        public double CostPrice {
            get => _costPrice;
            set
            {
                if (value > SalePrice)
                {
                    Console.WriteLine("SalePrice CostPrice dan boyuk ola bilmez");
                }
                else
                {
                    _costPrice = value;
                }

            }
        }

        public Product(double saleprice, double cosprice)
        {
            SalePrice = saleprice;
            CostPrice = cosprice;
        }


        public virtual void ShowSalePrice()
        {
            Console.WriteLine($"Satis Qiymeti{_salePrice}");
        }
        public virtual void ShowCostPrice()
        {
            Console.WriteLine($"alis Qiymeti{_costPrice}");
        }
        public virtual void ShowEarn()
        {
            double Earn = _salePrice - _costPrice;
            Console.WriteLine($"qazanc {Earn}");
        }
    }
}
