using CityBuilding.TileManagement;
using UnityEngine;

namespace CityBuilding.Managers
{
    public class GameManager : MonoBehaviour
    {
        [Header("Builder")]
        public GameObject tilePrefab;
        public Transform TilesHolder;
        public int levelWidth;
        public int levelLength;
        public float tileSize = 1;
        public float tileEndHeight = 0.84f;

        [Header("Resources")]
        public GameObject rockPrefab;
        public GameObject woodPrefab;
        [Range(0, 1)]
        public float obstacleChance = 0.3f;

        public int xBounds = 3;
        public int zBounds = 3;

        private void Start() {
            CreateLevel();
        }

        #region Level Design
        /// <summary>
        /// Create our grid depending on our level width and length
        /// </summary>
        public void CreateLevel() {
            for (int x = 0; x < levelWidth; x++) {
                for (int z = 0; z < levelLength; z++) {
                    TileObject spawnedTile = SpawnTile(x * tileSize, z * tileSize);

                    if (x < xBounds || z < zBounds ||
                        x >= (levelWidth - xBounds) ||
                        z >= (levelLength - zBounds))
                        spawnedTile.data.StarterTileValue(false);

                    if (spawnedTile.data.CanSpawnObstacle) {
                        bool spawnObstacle = Random.value <= obstacleChance;
                        if (spawnObstacle) {
                            // Handle the spawning obtacle here.
                            spawnedTile.data.SetOccupied(Tile.ObstacleType.Resource);
                            SpawnObstacle(spawnedTile.transform.position.x, spawnedTile.transform.position.z);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Spawns and return a tileObject
        /// </summary>
        /// <param name="xPos">X Position inside the World</param>
        /// <param name="zPos">Z Position inside the World</param>
        /// <returns></returns>
        private TileObject SpawnTile(float xPos, float zPos) {
            GameObject tmpTile = Instantiate(tilePrefab);
            tmpTile.transform.position = new Vector3(xPos, 0, zPos);
            tmpTile.transform.SetParent(TilesHolder);
            tmpTile.name = "Tile" + xPos + " - " + zPos;
            return tmpTile.GetComponent<TileObject>();
        }

        /// <summary>
        /// Spawn the resource obstacle directly in the coordinates.
        /// </summary>
        /// <param name="xPos"></param>
        /// <param name="zPos"></param>
        public void SpawnObstacle(float xPos, float zPos) {
            bool isWood = Random.value <= 0.5f; // 50% percent of spawning a wood obstacle.
            GameObject spawnedObject = null;

            if (isWood)
                spawnedObject = Instantiate(woodPrefab);
            else
                spawnedObject = Instantiate(rockPrefab);

            spawnedObject.transform.position = new Vector3(xPos, tileEndHeight, zPos);
        }
        #endregion
    }
}