using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog22 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 22/Dialog 22");
        }
        return dialog;
    }
}
