using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog8 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 8/Dialog 8");
        }
        return dialog;
    }
}
