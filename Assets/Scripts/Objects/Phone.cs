using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : Objects
{
    [SerializeField] private DialogScripter dialogScripter;
    [SerializeField] private AudioPhoneManager audioPhoneManager;
    [SerializeField] private GameObject panelDialog;
    [SerializeField] private GameObject panelDialogChanger;

    private bool _isMiniGame = false;
    public override void OnTriggerEnter(Collider other)
    {
        if (_isEnabled)
        {
            base.OnTriggerEnter(other);
            if (_isActive && other.name == "Doctor")
            {
                if (this.enabled && !_isMiniGame)
                {
                    dialogScripter.SetNewDialog();
                } else if (_isMiniGame)
                {
                    //Debug.Log("Minigame disabled");
                    
                }
            }
        }
    }

    public void ChangeMiniGameBool(bool value)
    {
        _isMiniGame = value;
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
