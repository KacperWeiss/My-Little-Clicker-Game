using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class City
    {
        /// <summary>
        /// City's resources count
        /// </summary>
        public Resources resources;

        /// <summary>
        /// Name of a city
        /// </summary>
        public String Name { get; private set; }

        /// <summary>
        /// Building object done by operator new with LumberMill class
        /// </summary>
        Building lumberMill = new LumberMill();
        /// <summary>
        /// Building object done by operator new with StoneMason class
        /// </summary>
        Building stoneMason = new StoneMason();
        /// <summary>
        /// Building object done by operator new with GoldMine class
        /// </summary>
        Building goldMine = new GoldMine();

        /// <summary>
        /// List of buildings
        /// </summary>
        List<Building> buildings;

        /// <summary>
        /// Constructs new city with given name
        /// </summary>
        /// <param name="name"></param>
        public City(String name)
        {
            this.Name = name;
            this.resources.Wood = 0;
            this.resources.Stone = 0;
            this.resources.Gold = 0;
            this.buildings = new List<Building>
            {
                lumberMill,
                stoneMason,
                goldMine
            };
        }

        /// <summary>
        /// Adds all resources on timer's tick
        /// </summary>
        public void AddResourcesOnTick()
        {
            foreach (var building in buildings)
            {
                building.AddResourcePerTick(ref resources);
            }
        }

        /// <summary>
        /// Adds resource on button click
        /// </summary>
        public void AddResourceOnClick(int buildingsNumber)
        {
            if (buildingsNumber > 2 || buildingsNumber < 0)
            {
                throw new Exception($"This building ID is not allowed: {buildingsNumber}");
            }
            buildings[buildingsNumber].AddResourcePecClick(ref resources);
        }

        /// <summary>
        /// Hires resource gatherer on button click
        /// </summary>
        /// <param name="buildingsNumber"></param>
        public void HireResourceGatherer(int buildingsNumber)
        {
            if (buildingsNumber > 2 || buildingsNumber < 0)
            {
                throw new Exception($"This building ID is not allowed: {buildingsNumber}");
            }
            buildings[buildingsNumber].HireResourceGatherer(ref resources);
        }

        /// <summary>
        /// Updates building on button click
        /// </summary>
        /// <param name="buildingsNumber"></param>
        public void UpgradeBuilding(int buildingsNumber)
        {
            if (buildingsNumber > 2 || buildingsNumber < 0)
            {
                throw new Exception($"This building ID is not allowed: {buildingsNumber}");
            }
            buildings[buildingsNumber].UpgradeBuilding(ref resources);
        }

        /// <summary>
        /// Returns string with current resource value.
        /// </summary>
        /// <param name="ResourceID"></param>
        /// <returns></returns>
        public string GetResource(int ResourceID)
        {
            switch (ResourceID)
            {
                case 0:
                    return Convert.ToString(resources.Wood);

                case 1:
                    return Convert.ToString(resources.Stone);

                case 2:
                    return Convert.ToString(resources.Gold);

                default:
                    throw new Exception($"This resource ID is not allowed: {ResourceID}");
            }
        }

        /// <summary>
        /// Alows city to be renamed
        /// </summary>
        /// <param name="newName"></param>
        public void Rename(string newName)
        {
            if(newName != null)
            {
                Name = newName;
                return;
            }
            throw new Exception("New name is not allowed to be null");
        }

        /// <summary>
        /// Returns quantity of resource gatherers
        /// </summary>
        /// <returns></returns>
        public string GetGatherersPopulation()
        {
            int populationCounter = 0;
            foreach (var building in buildings)
            {
                populationCounter += building.ResourceGatherers;
            }
            return populationCounter.ToString();
        }

        /// <summary>
        /// Returns resources required to upgrade building
        /// </summary>
        /// <param name="buildingID"></param>
        /// <returns></returns>
        public Resources GetUpgradeCost(int buildingID)
        {
            return buildings[buildingID].GetCosts();
        }

        /// <summary>
        /// Returns level of selected building
        /// </summary>
        /// <param name="buildingID"></param>
        /// <returns></returns>
        public string GetBuildingLevel(int buildingID)
        {
            return buildings[buildingID].Level.ToString();
        }

        /// <summary>
        /// Returns quantity of workers in selected building
        /// </summary>
        /// <param name="buildingID"></param>
        /// <returns></returns>
        public string GetWorkersNumber(int buildingID)
        {
            return buildings[buildingID].ResourceGatherers.ToString();
        }
    }
}
