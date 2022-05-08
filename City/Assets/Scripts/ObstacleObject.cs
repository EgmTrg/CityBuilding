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
        private bool pickedResource;

        private void OnMouseDown() {
            //Debug.Log($"Clicked to {gameObject.name}");
            switch (obstacleType) {
                case ObstacleType.Wood:
                    pickedResource = ResourceManager.Instance.AddWood(resourceAmount);
                    break;
                case ObstacleType.Rock:
                    pickedResource = ResourceManager.Instance.AddRock(resourceAmount);
                    break;
            }

            if (pickedResource)
                Destroy(gameObject);
            else
                Debug.Log("Could not collect this object because inventory is full");
        }
    }
}