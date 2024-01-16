using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotateAbstract : ShapeRot
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateShape();
    }
    protected override void RotateShape()
    {
        transform.rotation = Quaternion.Euler(targetRotation.x, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}
