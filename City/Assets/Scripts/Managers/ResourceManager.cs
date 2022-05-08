using System;
using UnityEngine;

namespace CityBuilding.Managers
{
    public class ResourceManager : MonoSingleton<ResourceManager>
    {
        #region Props
        public int MaxWood { get => maxWood; set => maxWood = value; }
        public int Wood { get => currentlyWood; set => currentlyWood = value; }
        public int MaxRock { get => maxRock; set => maxRock = value; }
        public int Rock { get => currentlyRock; set => currentlyRock = value; }
        public int MaxPremiumC { get => maxPremiumC; set => maxPremiumC = value; }
        public int PremiumC { get => currentlyPremiumC; set => currentlyPremiumC = value; }
        public int MaxStandardC { get => maxStandardC; set => maxStandardC = value; }
        public int StandardC { get => currentlyStandardC; set => currentlyStandardC = value; }
        #endregion

        #region ResourcesVariables
        [Header("Resources")]
        [SerializeField] private int maxWood;
        [SerializeField] private int currentlyWood = 0;
        [Space(10)]
        [SerializeField] private int maxRock;
        [SerializeField] private int currentlyRock = 0;
        [Space(10)]
        [SerializeField] private int maxPremiumC;
        [SerializeField] private int currentlyPremiumC = 0;
        [Space(10)]
        [SerializeField] private int maxStandardC;
        [SerializeField] private int currentlyStandardC = 0;
        #endregion

        private void Start() {
            UIManager.Instance.UpdateAllResources();
        }

        /// <summary>
        /// Adds wood to the inventory
        /// </summary>
        /// <param name="amount">Amount to add directly to our existing</param>
        public bool AddWood(int amount) {
            if ((currentlyWood + amount) <= maxWood) {
                currentlyWood += amount;
                UIManager.Instance.UpdateWoodUI(currentlyWood, maxWood);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds wood to the inventory
        /// </summary>
        /// <param name="amount">Amount to add directly to our existing</param>
        public bool AddRock(int amount) {
            if ((currentlyRock + amount) <= maxRock) {
                currentlyRock += amount;
                UIManager.Instance.UpdateRockUI(currentlyRock, maxRock);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds wood to the inventory
        /// </summary>
        /// <param name="amount">Amount to add directly to our existing</param>
        public bool AddStandardC(int amount) {
            if ((currentlyStandardC + amount) <= maxStandardC) {
                amount += amount;
                UIManager.Instance.UpdateStandardUI(currentlyStandardC, maxStandardC);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds wood to the inventory
        /// </summary>
        /// <param name="amount">Amount to add directly to our existing</param>
        public bool AddPremiumC(int amount) {
            if ((currentlyPremiumC + amount) <= maxPremiumC) {
                currentlyPremiumC += amount;
                UIManager.Instance.UpdatePremiumUI(currentlyPremiumC, maxPremiumC);
                return true;
            }
            return false;
        }

        [ContextMenu("Print Current Resources")]
        private void PrintCurrentResources() {
            Debug.Log($"Wood: {currentlyWood}");
            Debug.Log($"Rock: {currentlyRock}");
            Debug.Log($"StandardC: {currentlyStandardC}");
            Debug.Log($"PremiumC: {currentlyPremiumC}");
        }
    }
}