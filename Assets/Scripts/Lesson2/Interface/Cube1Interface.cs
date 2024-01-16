using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1Interface : MonoBehaviour, IRotatable
{
    [SerializeField] private Vector3 targetRotation;

   
    void Start()
    {
        
    }

    
    void Update()
    {
        Rotate();
    }

    
    public void Rotate()
    {
        transform.rotation = Quaternion.Euler(targetRotation);
    }
}
