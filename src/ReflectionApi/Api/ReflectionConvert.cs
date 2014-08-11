using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ReflectionApi.ClassMembers;

namespace ReflectionApi.Api
{
    public static class ReflectionConvert
    {
        public static List<VariableMember> SerializeToList<T>(T obj) where T : class
        {
            var memberBag = new List<VariableMember>();

            memberBag.AddRange(SerializeFields<T>(obj));
            memberBag.AddRange(SerializeProperties<T>(obj));

            return memberBag;
        }

        public static Dictionary<string, VariableMember> SerializeToDictionary<T>(T obj) where T : class
        {
            var memberBag = new Dictionary<string,VariableMember>();

            AddRange<Field>(memberBag, SerializeFields<T>(obj).ToDictionary(x => x.Name, y => new Field(y)));
            AddRange<Property>(memberBag, SerializeProperties<T>(obj).ToDictionary(x => x.Name, y => new Property(y)));

            return memberBag;
        }

        private static List<Field> SerializeFields<T>(T obj)
        {
            return
                typeof(T).GetFields().Select(m => new Field() { Name = m.Name, Type = m.FieldType, ReflectedType = m.ReflectedType, Value = m.GetValue(obj) }).ToList();
        }

        private static List<Property> SerializeProperties<T>(T obj)
        {
            return
                typeof(T).GetProperties().Select(m => new Property() { Name = m.Name, Type = m.PropertyType, ReflectedType = m.ReflectedType, Value = m.GetValue(obj) }).ToList();
        }

        private static void AddRange<T>(this Dictionary<string, VariableMember> target, Dictionary<string, T> source) where T : VariableMember
        {
            foreach(var val in source)
            {
                target.Add(val.Key, val.Value);
            }
        }

    }
}
