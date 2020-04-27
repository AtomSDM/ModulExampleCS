using System;
using module_interface;

namespace DefaultModule
{
    public class Default : AddonMaster
    {
        public string Name { set; get; }
        public Default()
        {
            Name = "First Module";
        }
        public void Run()
        {
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }
            
        }

        public bool Config(bool b)
        {
            return b;
        }

        public string Info()
        {
            return "Default Modul info";
        }
    }
}
