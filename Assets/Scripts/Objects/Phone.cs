using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : Objects
{
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (isActive && other.name == "Doctor")
        {
            Debug.Log("This is phone");
            isActive = false;
        }
    }
}
