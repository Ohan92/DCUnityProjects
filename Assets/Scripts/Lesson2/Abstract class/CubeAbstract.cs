using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ImplementAbstract
{
    public class CubeAbstract : ShapeRot
    {      
         protected override void RotateShape()
        {
            transform.rotation = Quaternion.Euler(targetRotation);
        }
    }

}

