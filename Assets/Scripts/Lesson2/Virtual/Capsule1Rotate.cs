using System.Collections;
using System.Collections.Generic;
using Lesson1;
using UnityEngine;

namespace ImplementVirtual
{
    public class Capsule1Rotate : VirtualRotate
    {
        protected override void ShapeRotate()
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, targetRotation.y, transform.eulerAngles.z);            
        }
    }
}
