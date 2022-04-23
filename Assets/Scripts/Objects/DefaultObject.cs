using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultObject : MonoBehaviour, ObjectsInterface
{
    public bool _isActive { get; set; }
    public bool _isEnabled { get; set; }
    public bool _miniGameEnabled { get; set; }
    public UIMiniGameManager _miniGameManager { get; set; }

    public ObjectsManager objectsManager;

    // Start is called before the first frame update
    void Start()
    {
        _isActive = false;
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        if (_isEnabled)
        {
            _isActive = true;
            objectsManager.Active(this);
        }
    }

    public Vector3 GetPoint()
    {
        return transform.position;
    }
}
