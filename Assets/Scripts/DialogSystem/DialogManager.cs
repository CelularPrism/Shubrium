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
        /*dialogInterface = new DialogOne();
        dialog = dialogInterface.GetDialog();
        dialogInterface.dialogManager = this;

        dialogChanger.SetNewText(dialog.text);*/
    }

    private void FixedUpdate()
    {
        if (!dialog.haveVariants)
        {
            variantsGameObject.SetActive(false);
            if (Input.anyKeyDown)
            {
                if (dialogChanger.CheckNowText())
                {
                    dialogInterface.ChangeSO();
                    if (dialog.dialog != null)
                        dialogChanger.SetNewText(dialog.dialog.text);

                    dialog = dialogInterface.GetDialog();
                }
            }
        } else
        {
            variantsGameObject.SetActive(true);
        }
    }

    public void CloseDialog()
    {
        variantsGameObject.SetActive(false);
        dialogChanger.gameObject.SetActive(false);
        transform.gameObject.SetActive(false);
    }

    public void SetDialog(DialogInterface dialog)
    {
        dialogInterface = dialog;
        dialogInterface.dialogManager = this;
        SetSODialog(dialog.GetDialog());
    }

    public void SetSODialog(SODialog dialog)
    {
        this.dialog = dialog;
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
