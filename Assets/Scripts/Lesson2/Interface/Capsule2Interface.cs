using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule2Interface : MonoBehaviour , IRotatable
{
    [SerializeField] private Vector3 targetRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }
    public void Rotate()
    {
        transform.rotation = Quaternion.Euler(targetRotation.x, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}
