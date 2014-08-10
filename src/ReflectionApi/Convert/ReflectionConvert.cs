using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ReflectionApi.ClassMembers;

namespace ReflectionApi.Convert
{
    public static class ReflectionConvert
    {

        public static List<Field> GetFields(Type objType)
        {
            return objType.GetFields().Select(m => new Field(){  Name = m.Name, Type = m.FieldType }).ToList();
        }

        public static List<Property> GetProperties(Type objType)
        {
            return objType.GetProperties().Select(m => new Property() {Name = m.Name, Type = m.PropertyType}).ToList();
        }


        public static List<string> GetMethods(Type objType)
        {
            var methodList = objType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Select(x => x.Name).ToList();

            return methodList;
        }
    }
}
