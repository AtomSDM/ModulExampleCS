using System;
using System.Reflection;
using module_interface;

namespace Modules
{
    class Modul : AddonMaster
    {
        public string Name { get; set; }

        AddonMaster obj;
        public Modul(string Dir)
        {
            Assembly asm = Assembly.LoadFrom(Dir);
            Type types = asm.GetType(Convert.ToString(asm.GetTypes()[0]), true, true);
            obj = Activator.CreateInstance(types) as AddonMaster;

            Name = obj.Name;
        }
        
        public void Run()
        {
            obj.Run();
        }
        public bool Config(bool boo)
        {
            return obj.Config(true);
        }
        public string Info()
        {
            return obj.Info();
        }
    }
}
