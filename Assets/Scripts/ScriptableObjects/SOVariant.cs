using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Variant", menuName = "ScriptableObjects/Dialog/Variant")]
public class SOVariant : ScriptableObject
{
    public string text;
    public float psycho;
    public float fatigue;
    public SODialog dialog;
}
