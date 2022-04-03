using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMachine : Objects
{
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (isActive && other.name == "Doctor")
        {
            Debug.Log("This is coffeeemachine");
            isActive = false;
        }
    }
}
