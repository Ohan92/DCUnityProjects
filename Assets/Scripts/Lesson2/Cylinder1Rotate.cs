using System.Collections;
using System.Collections.Generic;
using Lesson1;
using UnityEngine;

public class Cylinder1Rotate : CubeRot
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateCylinder();
    }
    void RotateCylinder()
    {
        transform.rotation = Quaternion.Euler(targetRotation.x, transform.eulerAngles.y, transform.eulerAngles.z);
    }

}
