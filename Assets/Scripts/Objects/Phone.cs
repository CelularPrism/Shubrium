using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : Objects
{
    [SerializeField] private DialogScripter dialogScripter;
    [SerializeField] private AudioPhoneManager audioPhoneManager;
    public override void OnTriggerEnter(Collider other)
    {
        if (_isEnabled)
        {
            base.OnTriggerEnter(other);
            if (_isActive && other.name == "Doctor")
            {
                if (this.enabled)
                {
                }
            }
        }
    }

    public void PickUp()
    {
        dialogScripter.SetNewDialog();
        //audioPhoneManager.PickUp();
        this.enabled = false;
        _isActive = false;
    }

    public void PutDown()
    {
        //audioPhoneManager.PutDown();
    }
}
