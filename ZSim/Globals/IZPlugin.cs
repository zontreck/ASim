using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZSim.Globals
{
    public interface IZPlugin
    {
        void run();
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Assembly)]
    public class Plugin : Attribute
    {
        public string Path;
        public string Name;
        public string ID;

        public Assembly AssignedAssembly;
        public Type AssignedClass;
        public MethodInfo AssignedMethod;

        /// <summary>
        /// Used in the Scan methods, will be overridden, do not set
        /// </summary>
        public string TypeOfAttribute;

        /// <summary>
        /// Identifies this class as a Plugin
        /// </summary>
        /// <param name="PluginPath"></param>
        /// <param name="PluginName"></param>
        /// <param name="PluginID"></param>
        public Plugin(string PluginPath, string PluginName, string PluginID)
        {
            Path = PluginPath;
            Name = PluginName;
            ID = PluginID;
            
            
        }

        public Plugin Copy()
        {
            Plugin p = new Plugin(Path, Name, ID);
            p.AssignedAssembly = AssignedAssembly;
            p.AssignedClass = AssignedClass;
            p.AssignedMethod = AssignedMethod;
            p.TypeOfAttribute = TypeOfAttribute;
            return p;
        }
    }
}
