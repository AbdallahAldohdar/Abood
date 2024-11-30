using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment19
{
    public class NewBehaviourScript : MonoBehaviour
    {
        public float x = 0f;
        public float progress = 5.0f;

        void Start()
        {
            
        }

        void Update()
        {
            if(Input.GetKey(KeyCode.RightArrow))
            {
                x += progress;
            }
            else if(Input.GetKey(KeyCode.LeftArrow))
            {
                x -= progress;
            }
            transform.position = new Vector3(x *2,0.1f,0);
        }
    }
}