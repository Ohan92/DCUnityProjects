using System;
using System.Collections;
using System.Collections.Generic;
using Lesson1;
using UnityEngine;

namespace ImplementVirtual
{
    public class CubeRotation : VirtualRotate
    {
        protected override void ShapeRotate()
        {            
            base.ShapeRotate();
        }
    }
}
