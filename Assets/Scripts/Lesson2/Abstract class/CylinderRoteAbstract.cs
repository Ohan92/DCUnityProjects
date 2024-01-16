using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRoteAbstract : ShapeRot
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
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, targetRotation.y, transform.eulerAngles.z);
    }
}
