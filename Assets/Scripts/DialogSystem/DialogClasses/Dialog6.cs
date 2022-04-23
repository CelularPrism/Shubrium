using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog6 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 6/Dialog 6");
        }
        return dialog;
    }
}
