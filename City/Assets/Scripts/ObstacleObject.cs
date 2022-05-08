using CityBuilding.Managers;
using UnityEngine;

namespace CityBuilding.Resources
{
    public class ObstacleObject : MonoBehaviour
    {
        public enum ObstacleType { Wood, Rock }
        public ObstacleType obstacleType;
        public int resourceAmount = 10;
            // resourceAmount = Random.Range(2, 10);
            // ya da 
            // resourceAmount = (int)(Random.value * 10f);

        private void OnMouseDown() {
            Debug.Log($"Clicked to {gameObject.name}");

            switch (obstacleType) {
                case ObstacleType.Wood:
                    ResourceManager.Instance.AddWood(resourceAmount);
                    break;
                case ObstacleType.Rock:
                    ResourceManager.Instance.AddRock(resourceAmount);
                    break;
                default:
                    break;
            }
        }
    }
}