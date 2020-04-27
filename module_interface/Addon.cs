using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_interface
{
    public interface AddonMaster
    {
        string Name { get; set; }
        void Run();
        bool Config(bool boo);
        string Info();
    }
    class Addon
    {
        Addon(AddonMaster am)
        {
            Console.WriteLine(am.Info());
        }
    }

}
