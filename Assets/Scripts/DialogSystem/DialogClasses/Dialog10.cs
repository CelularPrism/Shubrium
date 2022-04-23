using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog10 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 10/Dialog 10");
        }
        return dialog;
    }
}
