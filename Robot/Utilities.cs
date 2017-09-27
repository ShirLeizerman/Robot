using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    static class Utilities
    {
        static public string GenerateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        //static public void DicFromClass(Dictionary<string, Delegate> theDictionary, Type classType)
        static public void DicFromClass(Dictionary<string, MethodInfo> theDictionary, Type classType)
        {
            //Type robotType = Type.GetType(classStr);
            //Type robotType = (typeof(Activator.Create(className)));
            
            MethodInfo[] methodInfos = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            for (int i = 0; i<methodInfos.Length; i++)
            {
                MethodInfo methodInfo = methodInfos[i];
                theDictionary.Add(methodInfo.Name, methodInfo);
            }
        }
    }
}
