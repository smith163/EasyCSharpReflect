using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApi.ClassMembers
{
    public class Property : VariableMember
    {
        public Property(string Name, Type type) : base(Name, type) { }
        public Property() { }
        public Property(VariableMember obj) : base(obj) { }
    }
}
