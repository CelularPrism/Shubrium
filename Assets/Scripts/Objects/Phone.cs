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
                audioPhoneManager.PickUp();
                dialogScripter.SetNewDialog();
            }
            //this.enabled = false;
            isActive = false;
        }
    }
}
