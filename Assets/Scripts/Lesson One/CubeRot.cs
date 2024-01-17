    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

namespace Lesson1
{
    public class CubeRot : MonoBehaviour
    {
        [SerializeField] private Vector3 targetRotation;
        void Update()
        {
             transform.rotation = Quaternion.Euler(targetRotation);
        }
    }
}