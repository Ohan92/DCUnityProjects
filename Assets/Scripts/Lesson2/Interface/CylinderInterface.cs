using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderInterface : MonoBehaviour, IRotatable
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
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, targetRotation.y, transform.eulerAngles.z);
    }
}
