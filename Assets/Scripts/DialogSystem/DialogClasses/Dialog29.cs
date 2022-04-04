using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog29 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 29/Dialog 29");
        }
        return dialog;
    }
}
