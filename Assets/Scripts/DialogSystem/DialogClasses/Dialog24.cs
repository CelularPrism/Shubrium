using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog24 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 24/Dialog 24");
        }
        return dialog;
    }
}
