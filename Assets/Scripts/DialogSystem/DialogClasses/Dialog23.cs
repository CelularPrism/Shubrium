using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog23 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 23/Dialog 23");
        }
        return dialog;
    }
}
