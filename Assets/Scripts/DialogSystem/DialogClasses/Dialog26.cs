using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog26 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 26/Dialog 26");
        }
        return dialog;
    }
}
