using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShapeRot : MonoBehaviour
{
    [SerializeField] protected Vector3 targetRotation;

   
    protected abstract void RotateShape();
}



