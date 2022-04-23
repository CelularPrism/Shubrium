using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog16 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 16/Dialog 16");
        }
        return dialog;
    }
}
