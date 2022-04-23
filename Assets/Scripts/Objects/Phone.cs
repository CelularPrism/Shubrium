using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : Objects
{
    [SerializeField] private DialogScripter dialogScripter;
    [SerializeField] private AudioPhoneManager audioPhoneManager;

    [SerializeField] private GameObject _phoneHandset;

    private Light _phoneHandsetLight;
    private MeshRenderer _phoneHandsetRender;

    private Color _defaultPhoneHandsetColor;

    public bool _setDialog { get; set; } = false; //instead turn on/turn off script
    public override void Awake()
    {
        base.Awake();

        _newObjectColor = new Color(_defaultObjectColor.a + 0.07f, _defaultObjectColor.g + 0.055f, _defaultObjectColor.b + 0.035f);

        _phoneHandsetRender = GetComponent<MeshRenderer>();
        _phoneHandsetLight = GetComponent<Light>();

        _defaultPhoneHandsetColor = _phoneHandsetRender.material.color;
    }
    public override void OnMouseEnter()
    {
        if (_isEnabled)  //new part - if statement
        {
            base.OnMouseEnter();

            _phoneHandsetLight.enabled = true;
            _phoneHandsetRender.material.color = _newObjectColor;
        }
    }
    public override void OnMouseExit()
    {
        if (_isEnabled)  //new part - if statement
        {
            base.OnMouseExit();

            _phoneHandsetLight.enabled = false;
            _phoneHandsetRender.material.color = _defaultPhoneHandsetColor;
        }
    }
    public override void OnMouseDown()
    {
        if (_isEnabled)    //new part - if statement
        {
            if (_setDialog)
            {
                base.OnMouseDown();
                if (_mainCharacterAnimator.DoctorAnimatorController.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                {
                    _mainCharacterAnimator.GoToTarget();
                }
                else if (_mainCharacterAnimator.DoctorAnimatorController.GetCurrentAnimatorStateInfo(0).IsName("Moving"))
                {
                    //_isActive = true;
                    //objectsManager.DisableActive(this);
                }
                else if ((_mainCharacterAnimator.DoctorAnimatorController.GetCurrentAnimatorStateInfo(0).IsName("Sitting")))
                {
                    if (_setDialog)
                    {
                        _mainCharacterAnimator.StartDialog();
                    }
                }
                else
                {
                    _isActive = false;
                }
            }//make the state check
        }
    }
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
    public void PickUp()
    {
        dialogScripter.SetNewDialog();
        _setDialog = false;
        _isActive = false;
    }
    public void StartDialog()
    {
        if (_isEnabled && _isActive)
        {
            _mainCharacterMovement.SetRotation();
            _mainCharacterAnimator.StartDialog();
        }
    }
}
