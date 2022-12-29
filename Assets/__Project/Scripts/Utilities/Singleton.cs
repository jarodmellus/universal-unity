using UnityEngine;

namespace JTM.UnityUtilities {
    public static class MonoSingleton {
        public static bool TryInitialize<T>(T instance, ref T singleton) where T : MonoBehaviour {
            if(singleton!=null) {
                GameObject.Destroy(instance.gameObject);
                return false;
            }

            singleton = instance;
            return true;
        }
    }
}