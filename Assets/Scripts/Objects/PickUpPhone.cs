using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPhone : MonoBehaviour
{
    private MeshRenderer _phoneRender;
    private Color _defaultPhoneColor;

    private DoctorAnimator _doctorAnim;

    [SerializeField] private Phone _dialogScriptAllowed; //Здесь ссылка на скрипт (заменить string на тип скрипта), который вызывает начало диалога;

    private void Awake()
    {
        _doctorAnim = GameObject.Find("DoctorSitting").GetComponent<DoctorAnimator>();
        
        _phoneRender = GetComponent<MeshRenderer>();
        _defaultPhoneColor = _phoneRender.material.color;
    }

    public void OnMouseEnter()
    {
        
    }
    public void OnMouseExit()
    {

    }
    public void OnMouseDown()
    {
        if (_dialogScriptAllowed.isActive)
        {
            _doctorAnim.StartDialog();
        }
        else
        {
            Debug.Log("There is no calling");
        }
    }
}
