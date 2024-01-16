using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ImplementInterface
{
    public class Cube : MonoBehaviour, IRotatable
    {
        [SerializeField] private Vector3 targetRotation; 
        public void Rotate()
        {
            transform.rotation = Quaternion.Euler(targetRotation);
        }    
    }
}