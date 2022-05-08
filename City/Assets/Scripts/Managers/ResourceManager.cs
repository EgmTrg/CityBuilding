using System;
using UnityEngine;

namespace CityBuilding.Managers
{
    public class ResourceManager : MonoSingleton<ResourceManager>
    {
        #region ResourcesVariables
        [Header("Resources")]
        public int maxWood;
        private int wood = 0;

        public int maxRock;
        private int rock = 0;
        
        public int maxPremiumC;
        private int premiumC = 0;
        
        public int maxStandardC;
        private int standardC = 0;
        #endregion

        /// <summary>
        /// Adds wood to the inventory
        /// </summary>
        /// <param name="amount">Amount to add directly to our existing</param>
        public void AddWood(int amount) {
            wood += amount;
            UIManager.Instance.UpdateWoodUI(wood, maxWood);
        }

        /// <summary>
        /// Adds wood to the inventory
        /// </summary>
        /// <param name="amount">Amount to add directly to our existing</param>
        public void AddRock(int amount) {
            rock += amount;
            UIManager.Instance.UpdateRockUI(rock, maxRock);
        }

        /// <summary>
        /// Adds wood to the inventory
        /// </summary>
        /// <param name="amount">Amount to add directly to our existing</param>
        public void AddStandardC(int amount) {
            amount += amount;
            UIManager.Instance.UpdateStandardUI(standardC, maxStandardC);
        }

        /// <summary>
        /// Adds wood to the inventory
        /// </summary>
        /// <param name="amount">Amount to add directly to our existing</param>
        public void AddPremiumC(int amount) {
            premiumC += amount;
            UIManager.Instance.UpdatePremiumUI(premiumC, maxPremiumC);
        }

        [ContextMenu("Print Current Resources")]
        private void PrintCurrentResources() {
            Debug.Log($"Wood: {wood}");
            Debug.Log($"Rock: {rock}");
            Debug.Log($"StandardC: {standardC}");
            Debug.Log($"PremiumC: {premiumC}");
        }
    }
}