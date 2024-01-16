using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ImplementAbstract
{
    public class CylinderRoteAbstract : ShapeRot
    {
        
        protected override void RotateShape()
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, targetRotation.y, transform.eulerAngles.z);
        }
    }

}
