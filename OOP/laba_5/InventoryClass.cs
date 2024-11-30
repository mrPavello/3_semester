using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    public abstract partial class Inventory : IDescriptionInventory, IComparable<Inventory>
    {
        public override string ToString()
        {
            return Description;
        }
        public virtual void Application() { }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Inventory)) return false;
            Inventory other = (Inventory)obj;
            if (Name != other.Name) return false;

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(Inventory? obj)
        {
            if(obj == null) return 1;
            return Price.CompareTo(obj.Price);
        }
    }
}
