using UnityEngine;
using JTM.UnityUtilities;
using System;
using Sirenix.OdinInspector;

namespace JTM.Entity {
    public class TimeManager : SerializedMonoBehaviour
    {
        public Action action;
        public static TimeManager Singleton;
        
        [ShowInInspector]
        [ReadOnly]
        public static float globalTimeScale;

        void Awake() {
            if(!MonoSingleton.TryInitialize<TimeManager>(this, ref Singleton)) return;
        }

        public void DoAction() {

        }
    }
}