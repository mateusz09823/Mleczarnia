using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Mleczarnia
{
    class FarmsList
    {
        public static List<Farm> farmsList = new List<Farm>();
        private static FileStream MyStream;
        static FarmsList()
        {
        }
        public static List<Farm> GetFarmsList()
        {
            return farmsList;
        }
        public static void SetFarmsList(List<Farm> list)
        {
            farmsList = list;
        }

        public static int GetSizeOfList()
        {
            return farmsList.Count;
        }

        public static void Add(Farm farm)
        {
                farmsList.Add(farm);
        }

        public static Farm Get(int x)
        {
                return farmsList[x];
        }

        public static void Set(int x, string Name, string Surname, string Address, int Nip)
        {
               // farmsList[x].SetName(Name);
               // farmsList[x].SetSurame(Surname);
               // farmsList[x].SetAddress(Address);
               // farmsList[x].SetNip(Nip);
        }

        public static void Delete(int x)
        {
                farmsList.RemoveAt(x);
        }

        public static void SaveToFileFarms()

        {
            MyStream = new FileStream("C:\\Users\\" + Environment.UserName + "\\Desktop\\gospodarze.dat", FileMode.Create);
            BinaryFormatter MyFormatter = new BinaryFormatter();
            MyFormatter.Serialize(MyStream, FarmsList.GetFarmsList());
            MyStream.Close();
        }

        public static void LoadFromFileFarms()
        {
            MyStream = new FileStream("C:\\Users\\" + Environment.UserName + "\\Desktop\\gospodarze.dat", FileMode.OpenOrCreate);
            BinaryFormatter MyFormatter = new BinaryFormatter();
            if (MyStream.Length != 0)
            {
                farmsList = (List<Farm>)MyFormatter.Deserialize(MyStream);
            }
            MyStream.Close();
            FileInfo F = new FileInfo("C:\\Users\\" + Environment.UserName + "\\Desktop\\gospodarze.dat");
            if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Desktop\\gospodarze.dat"))
            {
                F.Delete();
            }

        }
    }
}
