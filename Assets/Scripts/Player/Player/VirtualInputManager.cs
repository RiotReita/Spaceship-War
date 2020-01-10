using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spaceship_war
{
    public class VirtualInputManager : Singleton<VirtualInputManager>
    {
        /* Movement */
        public float MoveVertical;
        public float MoveHorizontal;

        /* Combat */
        public bool LightFire;
        public bool HeavyFire;
        public bool SelectLightFire;
        public bool SelectHeavyFire;


        public float MouseScrolling;

        // Test
        public bool zero;


    }
}
