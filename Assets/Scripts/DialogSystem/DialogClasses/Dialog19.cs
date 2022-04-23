using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog19 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 19/Dialog 19");
        }
        return dialog;
    }
}
