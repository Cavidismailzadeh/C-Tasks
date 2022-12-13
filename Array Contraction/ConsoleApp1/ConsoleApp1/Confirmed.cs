using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Confirmed
    {
        public string name;
        public string surname;
        public string address;
       
    }
}

namespace ConsoleApp1
{
    internal class Confirmed2
{
    public string name;
    public string surname;
    public string address;

        public string FullConfirmed2()
        {
            return name + "-"+ surname +"-" + address;        }

}
}



namespace ConsoleApp1
{
    internal class Confirmed3
    {
        public string name;
        public string surname;
        public string address;

        public string FullConfirmed3()
        {
            return $"{name}, {surname}, {address}"; 
        }

    }
}
