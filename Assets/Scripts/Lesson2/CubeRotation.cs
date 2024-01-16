using System;
using System.Collections;
using System.Collections.Generic;
using Lesson1;
using UnityEngine;

public class CubeRotation : CubeRot
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       RotateCube();
    }

    void RotateCube()
    {
        transform.rotation = Quaternion.Euler(targetRotation);
    }
}
