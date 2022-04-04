using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog20 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 20/Dialog 20");
        }
        return dialog;
    }
}
