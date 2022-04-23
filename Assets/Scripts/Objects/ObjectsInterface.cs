using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ObjectsInterface
{
    public bool _isActive { get; set; }
    public bool _isEnabled { get; set; }
    public bool _miniGameEnabled { get; set; }

    public UIMiniGameManager _miniGameManager { get; set; }

    public Vector3 GetPoint();
}
