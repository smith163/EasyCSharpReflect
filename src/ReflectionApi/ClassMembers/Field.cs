using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApi.ClassMembers
{
    public class Field : VariableMember
    {
        public Field(string Name, Type type) : base(Name, type) { }
        public Field() { }
        public Field(VariableMember obj) : base(obj) { }
    }
}
