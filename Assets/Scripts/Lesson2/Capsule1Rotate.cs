using System.Collections;
using System.Collections.Generic;
using Lesson1;
using UnityEngine;

public class Capsule1Rotate : CubeRot
{
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //=> RotateCapsule();
    {
        RotateCapsule();
    }

    void RotateCapsule()
    {
        //transform.rotation = Quaternion.Euler(targetRotation);
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, targetRotation.y, transform.eulerAngles.z);
    }
}
