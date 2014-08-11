using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionApi.Interface;

namespace ReflectionApi.ClassMembers
{
    public abstract class VariableMember : IVariableMember
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public object Value { get; set; }

        protected VariableMember(string Name, Type type)
        {
            this.Name = Name;
            this.Type = type;
        }

        protected VariableMember() { }
    }
}
