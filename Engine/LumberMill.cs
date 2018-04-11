using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LumberMill : Building
    {        
        /// <summary>
        /// Constructor for class Lumberjack, initializes all necessary values
        /// </summary>
        public LumberMill()
        {
            Level = 1;
            ResourceGatherers = 5;
            Name = "Lumber mill";
            nextLevelCosts.Wood = 25;
            nextLevelCosts.Stone = 50;
            nextLevelCosts.Gold = 10;
        }

        /// <summary>
        /// Adds wood on click
        /// </summary>
        /// <param name="resources"></param>
        public override void AddResourcePecClick(ref Resources resources)
        {
            resources.Wood += Level * ResourceGatherers;
        }

        /// <summary>
        /// Adds wood on timer's tick
        /// </summary>
        /// <param name="resources"></param>
        public override void AddResourcePerTick(ref Resources resources)
        {
            double addedValue = Level * 10 * Math.Log10(Level + 1);
            resources.Wood += Convert.ToInt32(addedValue);
        }
    }
}
