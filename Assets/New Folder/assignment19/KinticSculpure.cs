using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment19
{
    public class KinticSculpure : MonoBehaviour
    {
        public float y = 0f;
        public float turn =1f;
        void Start()
        {
            
        }

        void Update()
        {
            y += turn;
            transform.rotation = Quaternion.Euler(new Vector3 (0,y,0));
            
        }
    }
}