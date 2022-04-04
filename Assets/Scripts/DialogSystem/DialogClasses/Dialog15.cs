using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog15 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 15/Dialog 15");
        }
        return dialog;
    }
}
