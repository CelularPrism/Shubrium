using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ObjectsInterface
{
    public bool isActive { get; set; }

    public Vector3 GetPoint();
}
