using UnityEngine;
using CityBuilding.Buildings;

namespace CityBuilding.Tile
{
    public class TileManager : MonoBehaviour
    {
        Building buildingRef;
        public bool occupied;
        public ObstacleType obstacleType;

        public enum ObstacleType
        {
            None,
            Resource,
            Building
        }

        public void SetOccupied(ObstacleType obsType) {
            occupied = true;
            obstacleType = obsType;
        }
        
        public void SetOccupied(ObstacleType obsType, Building building) {
            occupied = true;
            obstacleType = obsType;

            buildingRef = building;
        }

        public void CleanTile() {
            obstacleType = ObstacleType.None;
            occupied = false;
        }
    }
}
