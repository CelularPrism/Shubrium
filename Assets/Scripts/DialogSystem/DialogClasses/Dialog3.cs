using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog3 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 3/Dialog 3");
        }
        return dialog;
    }
}
