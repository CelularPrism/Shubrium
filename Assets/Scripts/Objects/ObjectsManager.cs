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
                objects.isActive = false;
                //Debug.Log(trans.name + " " + false);
            } else
            {
                playerMovement.SetPoint(objects.GetPoint());
            }
        }
    } 
}
