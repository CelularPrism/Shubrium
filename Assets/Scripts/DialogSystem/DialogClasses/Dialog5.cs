using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog5 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 5/Dialog 5");
        }
        return dialog;
    }
}
