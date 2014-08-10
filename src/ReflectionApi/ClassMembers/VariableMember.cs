using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApi.ClassMembers
{
    public abstract class VariableMember
    {
        public string Name;
        public Type Type;
        public object Value;

        protected VariableMember(string Name, Type type)
        {
            this.Name = Name;
            this.Type = type;
        }

        protected VariableMember() { }
    }
}
