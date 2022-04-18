using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPhone : MonoBehaviour
{
    [SerializeField] private Phone _dialogScriptAllowed;
    [SerializeField] private GameObject _phoneHandset;

    private Light _phoneLight;
    private MeshRenderer _phoneRender;
    private Light _phoneHandsetLight;
    private MeshRenderer _phoneHandsetRender;

    private Color _defaultPhoneColor;
    private Color _newPhoneColor;
    private Color _defaultPhoneHandsetColor;

    private DoctorAnimator _doctorAnim;

    private void Awake()
    {
        _doctorAnim = GameObject.Find("Doctor").GetComponent<DoctorAnimator>();
        
        _phoneRender = GetComponent<MeshRenderer>();
        _phoneLight = GetComponent<Light>();

        _defaultPhoneColor = _phoneRender.material.color;
        _newPhoneColor = new Color(_defaultPhoneColor.a + 0.07f, _defaultPhoneColor.g + 0.055f, _defaultPhoneColor.b + 0.035f);

        _phoneHandsetRender = GetComponent<MeshRenderer>();
        _phoneHandsetLight = GetComponent<Light>();

        _defaultPhoneHandsetColor = _phoneHandsetRender.material.color;
    }

    public void OnMouseEnter()
    {
        _phoneLight.enabled = true;
        _phoneHandsetLight.enabled = true; 

        _phoneRender.material.color = _newPhoneColor;
        _phoneHandsetRender.material.color = _newPhoneColor;
    }
    public void OnMouseExit()
    {
        _phoneLight.enabled = false;
        _phoneHandsetLight.enabled = false;

        _phoneRender.material.color = _defaultPhoneColor;
        _phoneHandsetRender.material.color = _defaultPhoneHandsetColor;
    }
    public void OnMouseDown()
    {
        if (_dialogScriptAllowed._isActive)
        {
            _doctorAnim.StartDialog();
        }
        else
        {
            Debug.Log("There is no calling");
        }
    }
}
