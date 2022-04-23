using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : Objects
{
    public override void Awake()
    {
        base.Awake();

        _newObjectColor = new Color(_defaultObjectColor.a + 0.03f, _defaultObjectColor.g + 0.008f, _defaultObjectColor.b + 0.008f);
    }

    public void Update()
    {
        if(_mainCharacterAnimator.DoctorAnimatorController.GetCurrentAnimatorStateInfo(0).IsName("SitDown") && _isEnabled)
        {
            _mainCharacterMovement.SetRotation();
            _isEnabled = false;
            _objectLight.enabled = false;
            _objectRender.material.color = _defaultObjectColor;
        }
    }
    public override void OnMouseEnter()
    {
        if (_isEnabled)   //new part - if statement
        {
            base.OnMouseEnter();
        }
    }
    public override void OnMouseExit()
    {
        if (_isEnabled)    //new part - if statement
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
        if (_isActive && _isEnabled) //new part - if statement
        {
            base.OnTriggerEnter(other);

            _mainCharacterAnimator.DoctorAnimatorController.SetTrigger("Sit");
            _mainCharacterTransform.LookAt(Camera.main.transform.position);
        }
    }
}
