using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : Objects
{
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (isActive && other.name == "Doctor")
        {
            Debug.Log("This is window");
            isActive = false;
        }
    }
}
