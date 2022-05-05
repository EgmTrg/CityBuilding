using UnityEngine;

namespace CityBuilding.Buildings
{
    [System.Serializable]
    public class Building
    {
        public int building_ID;

        public enum ResourceType { None, Standart, Premium }

        public int width = 0;
        public int height = 0;

        public ResourceType resourceType = ResourceType.None;
    }
}
