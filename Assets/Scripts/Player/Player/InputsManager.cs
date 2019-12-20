using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spaceship_war
{
    public class InputsManager : MonoBehaviour
    {
        void Update()
        {
            VirtualInputManager.Instance.MoveHorizontal = Input.GetAxisRaw("Horizontal");
            VirtualInputManager.Instance.MoveVertical = Input.GetAxisRaw("Vertical");

            VirtualInputManager.Instance.Fire1 = Input.GetButton("Fire1");

            VirtualInputManager.Instance.MouseScrolling = Input.GetAxis("Mouse ScrollWheel");
        }
    }
}
