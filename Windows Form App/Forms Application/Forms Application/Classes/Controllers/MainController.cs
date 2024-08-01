using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Forms_Application.Classes.Controllers
{
    public class MainController
    {
        public static void Main()
        {
            DistributorController dc = new DistributorController();
            dc.Debug_LogAllDistributors();
        }
    }
}
