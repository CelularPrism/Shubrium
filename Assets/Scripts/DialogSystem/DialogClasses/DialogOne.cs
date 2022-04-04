using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOne : DialogInterface
{
    public SODialog dialog { get; set; }

    public DialogManager dialogManager { get; set; }

    public SODialog GetDialog()
    {
        if (dialog == null)
        {
            dialog = Resources.Load<SODialog>("Dialog/New Folder/Dialog 1.1");
        }
        return dialog;
    }

    public void ChangeSO()
    {
        if (dialog.dialog != null && !dialog.haveVariants)
            dialog = dialog.dialog;
        else
        {
            dialogManager.CloseDialog();
        }
    }

    public void VariantA()
    {
        SOVariant variant = dialog.variants[0]; 
        dialogManager.ChangePsycho(variant.psycho);
        dialogManager.ChangeFatigue(variant.fatigue);

        dialogManager.SetSODialog(variant.dialog);
        dialog = variant.dialog;
    }

    public void VariantB()
    {
        SOVariant variant = dialog.variants[1];
        dialogManager.ChangePsycho(variant.psycho);
        dialogManager.ChangeFatigue(variant.fatigue);

        dialogManager.SetSODialog(variant.dialog);
        dialog = variant.dialog;
    }

    public void VariantC()
    {
        SOVariant variant = dialog.variants[2];
        dialogManager.ChangePsycho(variant.psycho);
        dialogManager.ChangeFatigue(variant.fatigue);

        dialogManager.SetSODialog(variant.dialog);
        dialog = variant.dialog;
    }

    public void VariantD()
    {
        SOVariant variant = dialog.variants[3];
        dialogManager.ChangePsycho(variant.psycho);
        dialogManager.ChangeFatigue(variant.fatigue);

        dialogManager.SetSODialog(variant.dialog);
        dialog = variant.dialog;
    }
}
