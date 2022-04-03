using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : Objects
{
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
            
        if(isActive && other.name == "Doctor")
        {
            //Debug.Log("This is chair");
            isActive = false;
        }
    }
}
