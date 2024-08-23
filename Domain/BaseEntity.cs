using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class BaseEntity
    {
        //public int Id { get;  set; }

        //public override bool Equals(object obj)
        //{
        //    if (obj == null || obj.GetType() != GetType())
        //        return false;

        //    var entity = (BaseEntity)obj;
        //    return Id == entity.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        public static bool operator ==(BaseEntity a, BaseEntity b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(BaseEntity a, BaseEntity b)
        {
            return !(a == b);
        }
    }
}
