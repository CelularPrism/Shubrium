using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMachine : Objects
{
    private Light _coffeeMachineLight;
    private MeshRenderer _coffeeMachineRender;

    private Color _defaultCoffeeMachineColor;
    private Color _newCoffeeMachineColor;
    private void Awake()
    {
        _coffeeMachineLight = GetComponent<Light>();
        _coffeeMachineRender = GetComponent<MeshRenderer>();

        _defaultCoffeeMachineColor = _coffeeMachineRender.material.color;
        _newCoffeeMachineColor = new Color(_defaultCoffeeMachineColor.a + 0.07f, _defaultCoffeeMachineColor.g + 0.008f, _defaultCoffeeMachineColor.b + 0.008f);
    }
    public void OnMouseEnter()
    {
        if (_isEnabled)
        {
            _coffeeMachineLight.enabled = true;
            _coffeeMachineRender.material.color = _newCoffeeMachineColor;
        }
    }
    public void OnMouseExit()
    {
        if (_isEnabled)
        {
            _coffeeMachineLight.enabled = false;
            _coffeeMachineRender.material.color = _defaultCoffeeMachineColor;
        }    }
    public override void OnTriggerEnter(Collider other)
    {
        if (_isEnabled)
        {
            base.OnTriggerEnter(other);
            if (_isActive && other.name == "Doctor")
            {
                _isActive = false;
            }        }
    }
}
