using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    abstract public class Building
    {
        /// <summary>
        /// Cost of next update
        /// </summary>
        protected Resources nextLevelCosts;

        /// <summary>
        /// Building's name
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Level of building
        /// </summary>
        public int Level { get; protected set; }

        /// <summary>
        /// Quantity of resource gatherers for this building.
        /// </summary>
        public int ResourceGatherers { get; protected set; }

        /// <summary>
        /// Adds resource per timer tick.
        /// </summary>
        abstract public void AddResourcePerTick(ref Resources resources);

        /// <summary>
        /// Adds resource per click
        /// </summary>
        abstract public void AddResourcePecClick(ref Resources resources);

        /// <summary>
        /// Upgrades building (adds 1 level)
        /// </summary>
        /// <param name="resources"></param>
        public Boolean UpgradeBuilding(ref Resources resources)
        {
            if (resources.Wood >= nextLevelCosts.Wood && resources.Stone >= nextLevelCosts.Stone)
            {
                resources.Wood -= nextLevelCosts.Wood;
                resources.Stone -= nextLevelCosts.Stone;

                nextLevelCosts.Wood = 2 * nextLevelCosts.Wood + Convert.ToInt32(Math.Log(nextLevelCosts.Wood));
                nextLevelCosts.Stone = 2 * nextLevelCosts.Stone + Convert.ToInt32(Math.Log(nextLevelCosts.Stone));

                Level++;
                return true;
            }
            throw new Exception($"Town lacks the resources to update {Name}.");
        }

        /// <summary>
        /// Hires more workers
        /// </summary>
        /// <param name="resources"></param>
        /// <returns></returns>
        public Boolean HireResourceGatherer(ref Resources resources)
        {
            if (resources.Gold >= nextLevelCosts.Gold)
            {
                resources.Gold -= nextLevelCosts.Gold;

                nextLevelCosts.Gold += Convert.ToInt32(Math.Log10(nextLevelCosts.Gold)); 

                ResourceGatherers++;
                return true;
            }
            throw new Exception($"Town lacks gold to hire more workers in {Name}.");
        }

        /// <summary>
        /// Returns resources required for next update
        /// </summary>
        /// <returns></returns>
        public Resources GetCosts()
        {
            return nextLevelCosts;
        }
    }
}
