using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog25 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 25/Dialog 25");
        }
        return dialog;
    }
}
