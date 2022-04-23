using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog7 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 7/Dialog 7");
        }
        return dialog;
    }
}
