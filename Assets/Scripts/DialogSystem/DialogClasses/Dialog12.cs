using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog12 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 12/Dialog 12");
        }
        return dialog;
    }
}
