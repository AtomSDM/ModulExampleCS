using module_interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Modules
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var dir = System.IO.Directory.GetCurrentDirectory();
            var ModulDir = dir + "\\Modules\\";
            Directory.CreateDirectory(ModulDir);
            var DllList = Directory
                .GetFiles(ModulDir, "*", SearchOption.AllDirectories)
                .ToList();

            Modul[] moduls = new Modul[DllList.Count()];

            int range = 0;
            foreach (var mo in DllList)
            {
                moduls[range] = new Modul(mo);
                range++;
            }



            #region Road to LoadModul
            //Assembly assembly = Assembly.LoadFrom();
            //Object obj = assembly.CreateInstance("AddonMaster");
            //Type typ = assembly.GetType("AddonMaster");

            //MethodInfo Method = typ.GetMethod("Run");
            //ParameterInfo[] Params = Method.GetParameters();

            //Assembly asm = Assembly.LoadFrom(ModulDir + "DefaultModule.dll");
            //Type types = asm.GetType("DefaultModule.Default", true, true);

            //object obj = Activator.CreateInstance(types);
            //ConstructorInfo method = types.GetConstructor(new Type[] { });

            //method.Invoke(obj, new Object[] { });
            //method.Invoke(obj, new Object[] { });

            #endregion

            foreach (var mod in moduls)
            {
                Console.WriteLine(mod.Name);
                if (mod.Config(true))
                {
                    mod.Run();
                }
                Console.WriteLine(mod.Info());
            }

            Console.ReadKey();   
        }

    }
}
