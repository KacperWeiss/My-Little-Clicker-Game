using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class StoneMason : Building
    {
        /// <summary>
        /// Constructor for class StoneMason, initializes all necessary values
        /// </summary>
        public StoneMason()
        {
            Level = 1;
            ResourceGatherers = 5;
            Name = "Stone mason";
            nextLevelCosts.Wood = 50;
            nextLevelCosts.Stone = 25;
            nextLevelCosts.Gold = 10;
        }

        /// <summary>
        /// Adds stone on click
        /// </summary>
        /// <param name="resources"></param>
        public override void AddResourcePecClick(ref Resources resources)
        {
            resources.Stone += Level * ResourceGatherers;
        }

        /// <summary>
        /// Adds stone on timer's tick
        /// </summary>
        /// <param name="resources"></param>
        public override void AddResourcePerTick(ref Resources resources)
        {
            double addedValue = Level * 10 * Math.Log10(Level + 1);
            resources.Stone += Convert.ToInt32(addedValue);
        }
    }
}
