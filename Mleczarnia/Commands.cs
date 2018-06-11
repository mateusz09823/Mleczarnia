using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mleczarnia
{
    public class Commands
    {
        private static RoutedUICommand retur;
        private static RoutedUICommand add;
        private static RoutedUICommand delete;
        private static RoutedUICommand print;

        static Commands()
        {
            retur = new RoutedUICommand("Return", "return", typeof(Commands));
            delete = new RoutedUICommand("Delete", "delete", typeof(Commands));
            add = new RoutedUICommand("Add", "add", typeof(Commands));
            print = new RoutedUICommand("Print", "print", typeof(Commands));
        }

        public static RoutedUICommand Return
        {
            get { return retur; }
            set { retur = value; }
        }
        public static RoutedUICommand Add
        {
            get { return add; }
            set { add = value; }
        }
        public static RoutedUICommand Delete
        {
            get { return delete; }
            set { delete = value; }
        }
        public static RoutedUICommand Print
        {
            get { return print; }
            set { print = value; }
        }
    }
}
