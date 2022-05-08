using UnityEngine;
using UnityEngine.UI;

namespace CityBuilding.Managers
{
    public class UIManager : MonoSingleton<UIManager>
    {
        [Header("References")]
        [SerializeField] private StandardUIReference woodUI;
        [SerializeField] private StandardUIReference rockUI;
        [SerializeField] private StandardUIReference standardUI;
        [SerializeField] private StandardUIReference premiumUI;

        public void UpdateAllResources() {
            UpdateWoodUI(ResourceManager.Instance.Wood, ResourceManager.Instance.MaxWood);
            UpdateRockUI(ResourceManager.Instance.Rock, ResourceManager.Instance.MaxRock);
            UpdatePremiumUI(ResourceManager.Instance.PremiumC, ResourceManager.Instance.MaxPremiumC);
            UpdateStandardUI(ResourceManager.Instance.StandardC, ResourceManager.Instance.MaxStandardC);
        }

        public void UpdateWoodUI(int currentAmount, int maxAmount) {
            woodUI.currentUIText.text = currentAmount.ToString();
            woodUI.maxUIText.text = "Max: " + maxAmount.ToString();

            woodUI.slider.maxValue = maxAmount;
            woodUI.slider.value = currentAmount;
        }

        public void UpdateRockUI(int currentAmount, int maxAmount) {
            rockUI.currentUIText.text = currentAmount.ToString();
            rockUI.maxUIText.text = "Max: " + maxAmount.ToString();

            rockUI.slider.maxValue = maxAmount;
            rockUI.slider.value = currentAmount;
        }

        public void UpdateStandardUI(int currentAmount, int maxAmount) {
            standardUI.currentUIText.text = currentAmount.ToString();
            standardUI.maxUIText.text = "Max: " + maxAmount.ToString();

            standardUI.slider.maxValue = maxAmount;
            standardUI.slider.value = currentAmount;
        }

        public void UpdatePremiumUI(int currentAmount, int maxAmount) {
            premiumUI.currentUIText.text = currentAmount.ToString();
            premiumUI.maxUIText.text = "Max: " + maxAmount.ToString();

            premiumUI.slider.maxValue = maxAmount;
            premiumUI.slider.value = currentAmount;
        }


    }

    [System.Serializable]
    public class StandardUIReference
    {
        public Slider slider;
        public Text maxUIText;
        public Text currentUIText;
    }
}
