using System.Collections;
using System.Collections.Generic;
using Lesson1;
using UnityEngine;

namespace ImplementVirtual
{
    public class Cylinder1Rotate : VirtualRotate
    {    
        protected override void ShapeRotate()
        {
            transform.rotation = Quaternion.Euler(targetRotation.x, transform.eulerAngles.y, transform.eulerAngles.z);
        }
    }
}
