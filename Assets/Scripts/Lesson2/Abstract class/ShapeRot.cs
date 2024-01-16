using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace ImplementAbstract
{
    public abstract class ShapeRot : MonoBehaviour
    {
        [SerializeField] protected Vector3 targetRotation;

        protected abstract void RotateShape();
        void Update()
        {
            RotateShape();
        }

        
    }

}




