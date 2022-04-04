using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog11 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 11/Dialog 11");
        }
        return dialog;
    }
}
