using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;
namespace GUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            BLL_HoaDon dt = new BLL_HoaDon();
            dt.loadHD();
            Console.ReadLine();
        }
    }
}
