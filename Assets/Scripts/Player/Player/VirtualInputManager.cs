using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spaceship_war
{
    public class VirtualInputManager : Singleton<VirtualInputManager>
    {
        public float MoveVertical;
        public float MoveHorizontal;
        public bool Fire1;
        public float MouseScrolling;
    }
}
