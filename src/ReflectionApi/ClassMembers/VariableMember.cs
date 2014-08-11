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
        private object _value;
        public object Value 
        { 
            get { return Convert.ChangeType(_value, Type); } 
            set { _value = Convert.ChangeType(value, Type); } 
        }
        public Type ReflectedType { get; set; }
        

        protected VariableMember(VariableMember obj)
        {
            this.Name = obj.Name;
            this.Type = obj.Type;
            this.Value = obj.Value;
            this.ReflectedType = obj.Type;
        }

        protected VariableMember(string Name, Type type)
        {
            this.Name = Name;
            this.Type = type;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as VariableMember);
        }

        public bool Equals(VariableMember obj)
        {
            return
                obj.Name == this.Name &&
                obj.ReflectedType == this.ReflectedType &&
                obj.Value == this.Value &&
                obj.Type == this.Type;
        }

        public override int GetHashCode()
        {
            return
                Name.GetHashCode() +
                Type.GetHashCode() +
                Value.GetHashCode() +
                ReflectedType.GetHashCode();
        }

        protected VariableMember() { }
    }
}
