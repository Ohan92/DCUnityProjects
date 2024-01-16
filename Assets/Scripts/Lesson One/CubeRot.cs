namespace Lesson1
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class CubeRot : MonoBehaviour
    {
        [SerializeField] protected Vector3 targetRotation;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            RotateCube();
        }

         void RotateCube()
        {
            transform.rotation = Quaternion.Euler(targetRotation);
            
        }

    }
}
