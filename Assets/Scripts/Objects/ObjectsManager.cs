using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManager : MonoBehaviour
{
    [SerializeField] private Transform[] objectsTrans;
    [SerializeField] private PlayerMovement playerMovement;
    public void DisableActive(ObjectsInterface objectInterface)
    {
        foreach (Transform trans in objectsTrans)
        {
            ObjectsInterface objects = trans.GetComponent<ObjectsInterface>();
            if (objects != objectInterface)
            {
                objects._isActive = false;
                //Debug.Log(trans.name + " " + false);
            } else
            {
                //Debug.Log(objects.GetPoint());
                playerMovement.SetPoint(objects.GetPoint());
            }
        }
    }

    public void EnabledObjects()
    {
        ObjectsInterface[] objects = transform.GetComponentsInChildren<ObjectsInterface>();
        foreach (ObjectsInterface obj in objects)
        {
            obj._isEnabled = true;
        }
    }

    public void DisabledObjects()
    {
        ObjectsInterface[] objects = transform.GetComponentsInChildren<ObjectsInterface>();
        foreach (ObjectsInterface obj in objects)
        {
            obj._isEnabled = false;
        }
    }
}
