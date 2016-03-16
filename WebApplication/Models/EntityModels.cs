using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public abstract class EntityModels
    {
        public int ID { get; set; }

        public EntityModels() { }

        public EntityModels(int id)
        {
            ID = id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            EntityModels o = (EntityModels)obj;
            return (this.ID == o.ID);
        }

        public override int GetHashCode()
        {
            return ID;
        }
        public override string ToString()
        {
            return ID.ToString();
        }
    }
}