using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ObjectsInterface
{
    public bool _isActive { get; set; }
    public bool _isEnabled { get; set; }   //new part

    public Vector3 GetPoint();   //new part
}
