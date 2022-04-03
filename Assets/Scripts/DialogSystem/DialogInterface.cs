using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface DialogInterface
{
    public SODialog dialog { get; set; }

    public DialogManager dialogManager { get; set; }

    public SODialog GetDialog();

    public void ChangeSO();

    public void VariantA();
    public void VariantB();
    public void VariantC();
    public void VariantD();
}
