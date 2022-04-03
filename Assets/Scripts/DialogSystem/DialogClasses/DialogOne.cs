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
            dialog = Resources.Load<SODialog>("Dialog/Dialog 1.1");
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

    public void ChangePsycho(float psycho, float fatigue)
    {

    }

    public void VariantA()
    {
        SOVariant variant = dialog.variants[0];
        ChangePsycho(variant.psycho, variant.fatigue);
        dialogManager.SetSODialog(variant.dialog);
        dialog = variant.dialog;
    }

    public void VariantB()
    {
        SOVariant variant = dialog.variants[1];
        ChangePsycho(variant.psycho, variant.fatigue);
        dialogManager.SetSODialog(variant.dialog);
        dialog = variant.dialog;
    }

    public void VariantC()
    {
        SOVariant variant = dialog.variants[2];
        ChangePsycho(variant.psycho, variant.fatigue);
        dialogManager.SetSODialog(variant.dialog);
        dialog = variant.dialog;
    }

    public void VariantD()
    {
        SOVariant variant = dialog.variants[3];
        ChangePsycho(variant.psycho, variant.fatigue);
        dialogManager.SetSODialog(variant.dialog);
        dialog = variant.dialog;
    }
}
