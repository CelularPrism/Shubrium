using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : Objects
{
    [SerializeField] private DialogScripter dialogScripter;
    [SerializeField] private AudioPhoneManager audioPhoneManager;
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (isActive && other.name == "Doctor")
        {
            if (this.enabled)
            {
                dialogScripter.SetNewDialog();
                PickUp();
                this.enabled = false;
            }
            isActive = false;
        }
    }

    public void PickUp()
    {
        audioPhoneManager.PickUp();
    }

    public void PutDown()
    {
        audioPhoneManager.PutDown();
    }
}
