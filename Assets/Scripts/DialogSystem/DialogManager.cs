using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    [SerializeField] private TextDialogChanger dialogChanger;
    [SerializeField] private GameObject variantsGameObject;
    private DialogInterface dialogInterface;
    private SODialog dialog;

    private void Start()
    {
        dialogInterface = new DialogOne();
        dialog = dialogInterface.GetDialog();
        dialogInterface.dialogManager = this;
        
        dialogChanger.SetNewText(dialog.text);
    }

    private void Update()
    {
        if (!dialog.haveVariants)
        {
            variantsGameObject.SetActive(false);
            if (dialogChanger.CheckOldText(dialog.dialog.text))
            {
                dialogChanger.SetNewText(dialog.dialog.text);
            }

            if (dialogChanger.CheckNowText())
            {
                dialogInterface.ChangeSO();
            }
        } else
        {
            variantsGameObject.SetActive(true);
        }
    }

    public void SetDialog(DialogInterface dialog)
    {
        dialogInterface = dialog;
        this.dialog = dialog.GetDialog();
        dialogChanger.SetNewText(this.dialog.text);
    }

    public void VariantA()
    {
        dialogInterface.VariantA();
    }

    public void VariantB()
    {
        dialogInterface.VariantB();
    }

    public void VariantC()
    {
        dialogInterface.VariantC();
    }

    public void VariantD()
    {
        dialogInterface.VariantD();
    }
}
