using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog9 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 9/Dialog 9");
        }
        return dialog;
    }
}
