using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog27 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 27/Dialog 27");
        }
        return dialog;
    }
}
