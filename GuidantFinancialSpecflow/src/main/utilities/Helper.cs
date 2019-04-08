using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidantFinancialSpecflow.src.main.utilities
{
    public class Helper
    {
       public static String getLibFolder()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GuidantFinancialTest\\lib";
        }
    }
}
