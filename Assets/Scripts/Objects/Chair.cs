using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : Objects
{
    private Light _chairLight;
    private MeshRenderer _chairRender;
    
    private Color _defaultChairColor;
    private Color _newChairColor;

    private void Awake()
    {
        _chairLight = GetComponent<Light>();
        _chairRender = GetComponent<MeshRenderer>();

        _defaultChairColor = _chairRender.material.color; //RGBA(0.260, 0.066, 0.077, 1.000)
        _newChairColor = new Color(_defaultChairColor.a + 0.03f, _defaultChairColor.g + 0.008f, _defaultChairColor.b + 0.008f);
    }
    public void OnMouseEnter()
    {
        _chairLight.enabled = true;
        _chairRender.material.color = _newChairColor;
    }
    public void OnMouseExit()
    {
        _chairLight.enabled = false;
        _chairRender.material.color = _defaultChairColor;
    }
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
            
        if(isActive && other.name == "Doctor")
        {
            
            isActive = false;
        }
    }
}
