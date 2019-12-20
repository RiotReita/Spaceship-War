using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spaceship_war {
    public class PlayerMovement : MonoBehaviour
    {
        public float Speed;  
        void Update()
        {
            float Horizontal = VirtualInputManager.Instance.MoveHorizontal * Speed * Time.deltaTime;
            float Vertical = VirtualInputManager.Instance.MoveVertical * Speed * Time.deltaTime;

            this.gameObject.transform.Translate(new Vector2( Horizontal, Vertical));
            this.gameObject.transform.rotation = Quaternion.Euler(0f,0f,0f);
        }
    }
}