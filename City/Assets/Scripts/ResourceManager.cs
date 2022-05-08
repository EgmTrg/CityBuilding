using UnityEngine;

namespace CityBuilding.Managers
{
    public class ResourceManager : MonoSingleton<ResourceManager>
    {
        [Header("Resources")]
        [Space(8)]
        public int maxWood;
        private int wood = 0;

        public int maxStone;
        private int stone = 0;
        
        public int maxPremiumC;
        private int premiumC = 0;
        
        public int maxStandardC;
        private int standardC = 0;

        private void Start() {
            Debug.LogWarning("Generic kullanarak tek methoda indirgeyebilirsin.");
        }

        /// <summary>
        /// Adds wood to the inventory
        /// </summary>
        /// <param name="amount">Amount to add directly to our existing</param>
        public void AddWood(int amount) {
            wood += amount;
            // update the element ui to show the correct amount of wood
        }

        /// <summary>
        /// Adds wood to the inventory
        /// </summary>
        /// <param name="amount">Amount to add directly to our existing</param>
        public void AddStone(int amount) {
            stone += amount;
        }

        /// <summary>
        /// Adds wood to the inventory
        /// </summary>
        /// <param name="amount">Amount to add directly to our existing</param>
        public void AddStandardC(int amount) {
            amount += amount;
        }

        /// <summary>
        /// Adds wood to the inventory
        /// </summary>
        /// <param name="amount">Amount to add directly to our existing</param>
        public void AddPremiumC(int amount) {
            premiumC += amount;
        }
    }
}