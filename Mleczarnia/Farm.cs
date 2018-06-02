using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mleczarnia
{
    [Serializable]
    class Farm
    {
        private string name;
        private string surname;
        private string address;
        private int nip;
        private int milkAmount = 0;

        public Farm(string Name, string Surname, string Address, int NIP)
        {
            name = Name;
            surname = Surname;
            address = Address;
            nip = NIP;
        }
   
        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetAddress()
        {
            return address;
        }
        public int GetNip()
        {
            return nip;
        }
        public int GetMilkAmount()
        {
            return milkAmount;
        }
        public void SetName(string Name)
        {
            name = Name;
        }
        public void SetSurame(string Surname)
        {
            surname = Surname;
        }
        public void SetAddress(string Address)
        {
            address = Address;
        }
        public void SetNip(int Nip)
        {
            nip = Nip;
        }

        public void SetMilkAmount(int MilkAmount)
        {
            milkAmount = MilkAmount;
        }

        Object farm;

        Farm(Object farm)
        {
            this.farm = farm;
        }
    }
}
