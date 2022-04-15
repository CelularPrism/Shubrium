using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultObject : MonoBehaviour, ObjectsInterface
{
    public bool isActive { get; set; }
    public ObjectsManager objectsManager;

    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        isActive = true;
        objectsManager.DisableActive(this);
    }

    public Vector3 GetPoint()
    {
        return transform.position;
    }
}
