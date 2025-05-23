using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftingSim.Model
{
    public class Material : IMaterial
    {
        int readonly Id;

        string readonly Name;

        public Material(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public bool Equals(IMaterial other)
        {
            if(other == null || other.GetType() != GetType()) return false;
            Material mat = (Material) other;
            return Id == mat.Id || Name == mat.Name;
        }


    }
}