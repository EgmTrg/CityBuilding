using UnityEngine;

namespace CityBuilding.Managers
{
    public class MonoSingleton<T> : MonoBehaviour where T: MonoSingleton<T>
    {
        private static volatile T instance;

        public static T Instance
        {
            get {
                if (instance == null) {
                    instance = GameObject.FindObjectOfType(typeof(T)) as T;
                }
                return instance;
            }
        }

    }
}