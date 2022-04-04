using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog17 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 17/Dialog 17");
        }
        return dialog;
    }
}
