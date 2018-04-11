using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class GoldMine : Building
    {
        /// <summary>
        /// Constructor for class GoldMine, initializes all necessary values
        /// </summary>
        public GoldMine()
        {
            Level = 1;
            ResourceGatherers = 2;
            Name = "Gold mine";
            nextLevelCosts.Wood = 50;
            nextLevelCosts.Stone = 50;
            nextLevelCosts.Gold = 15;
        }

        /// <summary>
        /// Adds gold on click
        /// </summary>
        /// <param name="resources"></param>
        public override void AddResourcePecClick(ref Resources resources)
        {
            resources.Gold += Convert.ToInt32(Level * ResourceGatherers/2);
        }

        /// <summary>
        /// Adds gold on timer's tick
        /// </summary>
        /// <param name="resources"></param>
        public override void AddResourcePerTick(ref Resources resources)
        {
            double addedValue = Level * 10 * Math.Log10(Level + 1);
            resources.Gold += Convert.ToInt32(addedValue);
        }
    }
}
