using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOne : DialogInterface
{
    public SODialog dialog { get; set; }

    public DialogManager dialogManager { get; set; }
    public DialogInterface nextDialog { get; set; }

    public SODialog GetDialog()
    {
        dialog = Resources.Load<SODialog>("Dialog/Dialog 1");
        nextDialog = new DialogTwo();
        return dialog;
    }

    public void ChangeSO()
    {
        dialog = dialog.dialog;
    }

    public void ChangePsycho(float psycho, float fatigue)
    {

    }

    public void VariantA()
    {
        dialogManager.SetDialog(nextDialog);
    }

    public void VariantB()
    {
        dialogManager.SetDialog(nextDialog);
    }

    public void VariantC()
    {
        dialogManager.SetDialog(nextDialog);
    }

    public void VariantD()
    {
        dialogManager.SetDialog(nextDialog);
    }
}
