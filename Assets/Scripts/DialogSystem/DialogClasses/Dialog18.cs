using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog18 : Dialog1
{
    public override SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/Dialog 18/Dialog 18");
        }
        return dialog;
    }
}
