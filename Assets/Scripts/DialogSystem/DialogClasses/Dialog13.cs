using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog13 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 13/Dialog 13");
        }
        return dialog;
    }
}
