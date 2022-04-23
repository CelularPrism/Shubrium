using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog14 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 14/Dialog 14");
        }
        return dialog;
    }
}
