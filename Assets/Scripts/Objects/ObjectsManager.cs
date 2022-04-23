using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManager : MonoBehaviour
{
    //This script is attached to prefab of room
    [SerializeField] private Transform[] objectsTrans;
    //[SerializeField] private PlayerMovement playerMovement;  //the previous version of script
    [SerializeField] private DoctorMovement doctorMovement;
    public void DisableActive(ObjectsInterface objectInterface)
    {
        foreach (Transform trans in objectsTrans)
        {
            ObjectsInterface objects = trans.GetComponent<ObjectsInterface>();
            if (objects != objectInterface)
            {
                objects._isActive = false;
            } 
            else
            {
                doctorMovement.SetPoint(objects.GetPoint());
                //playerMovement.SetPoint(objects.GetPoint()); //the previous version of script with script PlayerMovement
            }
        }
    }

    public void EnabledObjects()     //new part
    {
        ObjectsInterface[] objects = transform.GetComponentsInChildren<ObjectsInterface>();
        foreach (ObjectsInterface obj in objects)
        {
            obj._isEnabled = true;
        }
        Debug.Log("Able all objects " + Time.realtimeSinceStartup);
    }

    public void DisabledObjects()     //new part
    {
        ObjectsInterface[] objects = transform.GetComponentsInChildren<ObjectsInterface>();
        foreach (ObjectsInterface obj in objects)
        {
            obj._isEnabled = false;
        }
        Debug.Log("Disable all objects " + Time.realtimeSinceStartup);
    }
}
