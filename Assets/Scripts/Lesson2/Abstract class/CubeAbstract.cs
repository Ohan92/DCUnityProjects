using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeAbstract : ShapeRot
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

    // Реализация вращения для куба
    protected override void RotateShape()
    {
        transform.rotation = Quaternion.Euler(targetRotation);
    }
}

