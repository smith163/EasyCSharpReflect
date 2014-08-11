using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApi.Interface
{
    public interface IVariableMember
    {
        string Name { get; set; }
        Type Type { get; set; }
        object Value { get; set; }
        Type ReflectedType { get; set; }
    }
}
