using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog2 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 2/Dialog 2");
        }
        return dialog;
    }
}
