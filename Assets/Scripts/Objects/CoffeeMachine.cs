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
        _coffeeMachineLight.enabled = true;
        _coffeeMachineRender.material.color = _newCoffeeMachineColor;
    }
    public void OnMouseExit()
    {
        _coffeeMachineLight.enabled = false;
        _coffeeMachineRender.material.color = _defaultCoffeeMachineColor;
    }
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (isActive && other.name == "Doctor")
        {
            //Debug.Log("This is coffeeemachine");
            isActive = false;
        }
    }
}
