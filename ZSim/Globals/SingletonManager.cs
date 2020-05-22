using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSim.Globals
{
    public sealed class SingletonManager
    {
        private static readonly object lck = new object();
        private static SingletonManager inst;
        static SingletonManager() { }
        public static SingletonManager Instance
        {
            get
            {
                if (inst != null) return inst;
                lock (lck)
                {
                    if (inst == null) inst = new SingletonManager();
                    return inst;
                }
            }
        }


        public Dictionary<string, object> Singletons = new Dictionary<string, object>();
    }
}
