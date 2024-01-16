using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ImplementVirtual
{
    public class VirtualRotate : MonoBehaviour
    {
        [SerializeField] protected Vector3 targetRotation;
        
        void Update()
        {
            ShapeRotate();
        }

        protected virtual void ShapeRotate()
        {
            transform.rotation = Quaternion.Euler(targetRotation);
        }
    }

}
