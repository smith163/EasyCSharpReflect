using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionApi.Convert
{
    public static class ReflectionConvert
    {
        public static List<string> GetVariables(Type objType)
        {
            
            var varList = objType.GetFields().Select(variable => variable.Name).ToList();
            var propList = objType.GetProperties().Select(variable => variable.Name).ToList();

            propList.AddRange(varList);

            return propList;
        }
    }
}
