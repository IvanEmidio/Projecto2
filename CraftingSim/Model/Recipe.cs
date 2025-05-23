using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftingSim.Model
{
    public class Recipe : IRecipe
    {
        string readonly Name;

        double readonly SuccessRate;

        public IReadOnlyDictionary<IMaterial, int> RequiredMaterials;

        public Recipe(string name, double successRate, Dictionary<Material, int> material)
        {
            this.Name = name;
            this.SuccessRate = successRate;
            this.RequiredMaterials = material;
        }

        public int CompareTo(IRecipe other)
        {
            if (other == null) return 1;
            return Name.CompareTo(other.Name);
        }
    }
}