using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog30 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 30/Dialog 30");
        }
        return dialog;
    }
}
