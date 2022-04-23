using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManager : MonoBehaviour
{
    [SerializeField] private Transform[] objectsTrans;
    [SerializeField] private PlayerMovement playerMovement;
    public bool miniGameActive = false;

    private ObjectsInterface _objectInterface;
    private GameObject _panelMiniGame;



    private void EnableMiniGame()
    {
        ObjectsInterface[] objects = transform.GetComponentsInChildren<ObjectsInterface>();
        foreach (ObjectsInterface obj in objects)
        {
            obj._miniGameEnabled = true;
        }
    }

    private void DisableMiniGame()
    {
        ObjectsInterface[] objects = transform.GetComponentsInChildren<ObjectsInterface>();
        foreach (ObjectsInterface obj in objects)
        {
            obj._miniGameEnabled = false;
        }
    }

    private void DisableActive()
    {
        //Debug.Log(_objectInterface);
        foreach (Transform trans in objectsTrans)
        {
            ObjectsInterface objects = trans.GetComponent<ObjectsInterface>();
            if (objects != _objectInterface)
            {
                objects._isActive = false;
                //Debug.Log(trans.name + " " + false);
            }
            else
            {
                //Debug.Log(objects.GetPoint());
                playerMovement.SetPoint(objects.GetPoint());
            }
        }
    }

    public void Active(ObjectsInterface objectInterface)
    {
        if (miniGameActive)
        {
            EnableMiniGame();
        } else
        {
            DisableMiniGame();
        }

        _objectInterface = objectInterface;
        DisableActive();
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
