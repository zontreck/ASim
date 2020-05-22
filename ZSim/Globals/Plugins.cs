using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZSim.Globals
{
    public class Plugins
    {
        /// <summary>
        /// Loads a DLL
        /// </summary>
        /// <param name="DLL">DLL Filename</param>
        /// <returns>A handle to the loaded assembly</returns>
        public static Assembly Load(string DLL)
        {
            return Assembly.LoadFile(DLL);
        }

        /// <summary>
        /// Scans for implementations of type, then returns their Type as a object in this response
        /// </summary>
        /// <typeparam name="T">Interface to scan for</typeparam>
        /// <returns>List of implementations</returns>
        public static List<object> ScanByImplementation<T>()
        {
            // Scans the AppDomain for a specific implementation
            List<object> implementations = new List<object>();

            foreach(Assembly A in AppDomain.CurrentDomain.GetAssemblies())
            {
                for(int i = 0; i < A.GetTypes().Length; i++)
                {
                    Type _T = A.GetTypes()[i];
                    if(_T is T)
                    {
                        implementations.Add(_T);
                    }
                }
            }

            return implementations;
        }

        public static Dictionary<Plugin,string> ScanByAttribute()
        {


            Dictionary<Plugin, string> items = new Dictionary<Plugin, string>(); // Object then string so we can specify what the attribute was applied to
            // Scans the AppDomain for anything using the attribute <T>
            
            for(int i = 0; i < AppDomain.CurrentDomain.GetAssemblies().Length; i++)
            {
                Assembly A = AppDomain.CurrentDomain.GetAssemblies()[i];
                Plugin[] aT = (Plugin[])A.GetCustomAttributes<Plugin>();
                if (aT.Length > 0)
                {
                    foreach(Plugin plg in aT)
                    {
                        Plugin p1 = plg.Copy();
                        p1.TypeOfAttribute = "Assembly";
                        p1.AssignedAssembly = A;
                        items.Add(p1, "Assembly");
                    }
                }

                for(int ia =0; ia < A.GetTypes().Length; ia++)
                {
                    Type T = A.GetTypes()[ia];
                    aT = (Plugin[])T.GetCustomAttributes<Plugin>();
                    if (aT.Length > 0)
                    {
                        foreach(Plugin plg in aT)
                        {
                            Plugin p1 = plg.Copy();
                            p1.AssignedClass = T;
                            p1.TypeOfAttribute = "Class";
                            items.Add(p1, "Class");
                        }
                    }

                    for(int ib = 0; ib < T.GetMethods().Length; ib++)
                    {
                        MethodInfo MI = T.GetMethods()[ib];
                        aT = (Plugin[])MI.GetCustomAttributes<Plugin>();
                        if (aT.Length > 0)
                        {
                            foreach(Plugin plg in aT)
                            {
                                Plugin p1 = plg.Copy();
                                p1.AssignedMethod = MI;
                                p1.TypeOfAttribute = "Method";
                                items.Add(p1, "Method");
                            }
                        }
                    }
                }
            }


            return items;
        }
    }

    public class CannotScanByAttributeException : Exception
    {
        public CannotScanByAttributeException(string Msg) : base(Msg)
        {

        }
    }
}
