using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ImplementInterface
{
    public class Cylinder : MonoBehaviour, IRotatable
    {
        [SerializeField] private Vector3 targetRotation; 
        public void Rotate()
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, targetRotation.y, transform.eulerAngles.z);            
        }    
    }
}       