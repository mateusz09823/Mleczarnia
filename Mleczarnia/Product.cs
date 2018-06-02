using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mleczarnia
{
    [Serializable]
    class Product
    {
            private string name;
            private string type;
            private string amountInPack;
            private double amountMilk;
            private int made = 0;
            private int sold = 0;

           public Product(string Name, string Type, string AmountInPack, double AmountMilk)
            {
                name = Name;
                type = Type;
                amountInPack = AmountInPack;
                amountMilk = AmountMilk;
            }

            public string GetName()
            {
                return name;
            }
            public string GetType()
            {
                return type;
            }
            public string GetAmountInPack()
            {
                return amountInPack;
            }
            public double GetAmountMilk()
            {
                return amountMilk;
            }
            public int GetMade()
            {
                return made;
            }
            public int GetSold()
            {
                return sold;
            }
             public void SetName(string Name)
            {
                name = Name;
            }
            public void SetType(string Type)
            {
                type = Type;
            }
            public void SetAmountInPack(string AmountInPack)
            {
                amountInPack = AmountInPack;
            }
            public void SetAmountMilk(double AmountMilk)
            {
                amountMilk = AmountMilk;
            }

            public void SetMade(int Made)
            {
                made = Made;
            }
            public void SetSold(int Sold)
            {
            sold = Sold;
            }

            Object product;

            Product(Object product)
            {
                this.product = product;
            }
        }
}
