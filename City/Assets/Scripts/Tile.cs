using CityBuilding.Buildings;

namespace CityBuilding.TileManagement
{
    [System.Serializable]
    public class Tile
    {
        public Building buildingRef;
        public ObstacleType obstacleType;
        bool isStarterTile = true;
        
        public enum ObstacleType { None, Resource, Building }
        #region Props
        public bool IsOccupied { get { return obstacleType != ObstacleType.None; } }
        public bool CanSpawnObstacle { get { return !isStarterTile; } }
        #endregion

        public void SetOccupied(ObstacleType obsType) {
            obstacleType = obsType;
        }

        public void SetOccupied(ObstacleType obsType, Building building) {
            obstacleType = obsType;
            buildingRef = building;
        }

        public void CleanTile() {
            obstacleType = ObstacleType.None;
        }

        public void StarterTileValue(bool value) {
            isStarterTile = value;
        }
    }
}
