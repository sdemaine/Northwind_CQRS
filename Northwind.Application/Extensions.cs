using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application
{
    public static class Extensions
    {
        public static Assembly GetAssemblyByName(this AppDomain domain, string assemblyName)
        {
            return domain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == assemblyName);
        }
    }
}
