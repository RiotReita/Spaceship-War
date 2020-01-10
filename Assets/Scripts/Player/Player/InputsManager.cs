using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spaceship_war
{
    public class InputsManager : MonoBehaviour
    {
        void Update()
        {
            // Movement
            VirtualInputManager.Instance.MoveHorizontal = Input.GetAxisRaw("Horizontal");
            VirtualInputManager.Instance.MoveVertical = Input.GetAxisRaw("Vertical");

            // Combat
            VirtualInputManager.Instance.LightFire = Input.GetButton("A");
            VirtualInputManager.Instance.HeavyFire = Input.GetButton("X");
            VirtualInputManager.Instance.SelectLightFire = Input.GetButton("RB");
            VirtualInputManager.Instance.SelectHeavyFire = Input.GetButton("LB");

            VirtualInputManager.Instance.zero = Input.GetButton("B");

            VirtualInputManager.Instance.MouseScrolling = Input.GetAxis("Mouse ScrollWheel");
        }
    }
}
