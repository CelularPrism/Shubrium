using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMachine : Objects
{
    public override void Awake()
    {
        base.Awake();

        _newObjectColor = new Color(_defaultObjectColor.a + 0.07f, _defaultObjectColor.g + 0.008f, _defaultObjectColor.b + 0.008f);
    }
    public override void OnMouseEnter()
    {
        if (_isEnabled)      //new part - if statement
        {
            base.OnMouseEnter();
        }
    }
    public override void OnMouseExit()
    {
        if (_isEnabled)     //new part - if statement
        {
            base.OnMouseExit();
        }
    }
    public override void OnMouseDown()
    {
        if (_isEnabled)    //new part - if statement
        {
            base.OnMouseDown();
            _mainCharacterAnimator.GoToTarget();
        }
    }
    public override void OnTriggerEnter(Collider other)
    {
        if (_isActive && _isEnabled)  //new part - if statement
        {
            base.OnTriggerEnter(other);
            Debug.Log("Coffee Time!");
            _mainCharacterAnimator.DoctorAnimatorController.SetTrigger("Coffee");

            objectsManager.DisabledObjects(); //while drinking coffee, disable all objects P.S. the phone is enable - since the dialogSripter enabled all objects every fixedupdate time (see dialog scripter and objectsscripter)
        }
    }
}
