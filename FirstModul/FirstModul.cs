using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using module_interface;

namespace FirstModul
{
    public class FirstModul : AddonMaster
    {
        public string Name { set; get; }
        public FirstModul()
        {
            Name = "First Module Yo Suka";
        }
        public void Run()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Цикл Второго пользовательского модуля");
                Console.WriteLine(i);
            }

        }

        public bool Config(bool b)
        {
            return b;
        }

        public string Info()
        {
            return "EEEEEEEEEEEEEEEEE BoY!!!!!!!!!!!!!!!!!!!";
        }
    }
}
