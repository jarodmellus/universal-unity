using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JTM.Entity {

    public class Entity
    {
        float timeScale = 1f;
        public float TimeScale() => timeScale;

        private float activeTimeScale;
        public bool ignoreGlobalTimeScale {get;set;}

        //on time manager invoke change, subscriber entities update timescale
        void UpdateActiveTimeScale() {
            activeTimeScale = ignoreGlobalTimeScale 
            ? activeTimeScale 
            : activeTimeScale * TimeManager.globalTimeScale;
        }

    }
}
