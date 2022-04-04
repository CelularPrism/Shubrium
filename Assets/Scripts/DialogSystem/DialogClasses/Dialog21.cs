using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog21 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 21/Dialog 21");
        }
        return dialog;
    }
}
