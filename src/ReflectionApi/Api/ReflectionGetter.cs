using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ReflectionApi.ClassMembers;

namespace ReflectionApi.Api
{
    public static class ReflectionGetter
    {

        /// <summary>
        /// Set value to -1 for reading purposes
        /// </summary>
        /// <param name="objType"></param>
        /// <returns></returns>
        public static List<Field> GetFields(Type objType)
        {
            return objType.GetFields().Select(m => new Field(){  Name = m.Name, Type = m.FieldType, ReflectedType = m.ReflectedType, Value = Convert.ChangeType(-1, m.FieldType)}).ToList();
        }

        public static List<Property> GetProperties(Type objType)
        {
            return objType.GetProperties().Select(m => new Property() { Name = m.Name, Type = m.PropertyType, ReflectedType = m.ReflectedType, Value = Convert.ChangeType(-1, m.PropertyType) }).ToList();
        }

        public static List<VariableMember> GetVariableMembers(Type objType)
        {
            var memberList = new List<VariableMember>();
               
            memberList.AddRange(GetFields(objType));
            memberList.AddRange(GetProperties(objType));

            return memberList;

        }

        public static List<string> GetMethods(Type objType)
        {
            var methodList = objType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Select(x => x.Name).ToList();

            return methodList;
        }
    }
}
