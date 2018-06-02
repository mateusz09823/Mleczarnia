using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Mleczarnia
{
    class ProductsList
    {
        public static List<Product> productsList = new List<Product>();
        private static FileStream MyStream;
        static ProductsList()
        {
        }
        public static List<Product> GetFarmsList()
        {
            return productsList;
        }
        public static void SetProductsList(List<Product> list)
        {
            productsList = list;
        }

        public static int GetSizeOfList()
        {
            return productsList.Count;
        }

        public static void Add(Product product)
        {
            productsList.Add(product);
        }

        public static Product Get(int x)
        {
            return productsList[x];
        }

        public static void Set(int x, string Name, string Type, string AmountInPack, double AmountMilk)
        {
            productsList[x].SetName(Name);
            productsList[x].SetType(Type);
            productsList[x].SetAmountInPack(AmountInPack);
            productsList[x].SetAmountMilk(AmountMilk);
        }

        public static void Delete(int x)
        {
            productsList.RemoveAt(x);
        }

        public static void SaveToFileProducts()

        {
            MyStream = new FileStream("C:\\Users\\" + Environment.UserName + "\\Desktop\\produkty.dat", FileMode.Create);
            BinaryFormatter MyFormatter = new BinaryFormatter();
            MyFormatter.Serialize(MyStream, ProductsList.GetFarmsList());
            MyStream.Close();
        }

        public static void LoadFromFileProducts()
        {
            MyStream = new FileStream("C:\\Users\\" + Environment.UserName + "\\Desktop\\produkty.dat", FileMode.OpenOrCreate);
            BinaryFormatter MyFormatter = new BinaryFormatter();
            if (MyStream.Length != 0)
            {
                productsList = (List<Product>)MyFormatter.Deserialize(MyStream);
            }
            MyStream.Close();
            FileInfo F = new FileInfo("C:\\Users\\" + Environment.UserName + "\\Desktop\\produkty.dat");
            if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Desktop\\produkty.dat"))
            {
                F.Delete();
            }

        }
    }
}
