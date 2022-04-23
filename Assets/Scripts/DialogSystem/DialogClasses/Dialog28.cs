using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog28 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 28/Dialog 28");
        }
        return dialog;
    }
}
