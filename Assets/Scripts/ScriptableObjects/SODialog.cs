using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Dialog", menuName = "ScriptableObjects/Dialog/Dialog")]
public class SODialog : ScriptableObject
{
    public string text;
    public bool haveVariants;
    public SOVariant[] variants;
    public SODialog dialog;
}
