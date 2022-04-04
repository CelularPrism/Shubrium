using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog4 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 4/Dialog 4");
        }
        return dialog;
    }
}
