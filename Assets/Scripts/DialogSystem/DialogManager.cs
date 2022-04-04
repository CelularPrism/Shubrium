using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    [SerializeField] private PsychoController psychoController;
    [SerializeField] private TextDialogChanger dialogChanger;
    [SerializeField] private GameObject variantsGameObject;

    public bool isActive = true;

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
            SetVariants();
            variantsGameObject.SetActive(true);
        }
    }

    private void SetVariants()
    {
        int index = 0;
        foreach(Transform variant in variantsGameObject.transform)
        {
            variant.GetChild(0).GetComponent<Text>().text = dialog.variants[index].text;
            index++;
        }
    }

    public void ChangePsycho(float psycho)
    {
        psychoController.ChangePsycho(psycho);
    }

    public void ChangeFatigue(float fatigue)
    {
        psychoController.ChangeFatigue(fatigue);
    }

    public void CloseDialog()
    {
        variantsGameObject.SetActive(false);
        dialogChanger.gameObject.SetActive(false);
        transform.gameObject.SetActive(false);
        isActive = false;
    }

    public void SetDialog(DialogInterface dialog)
    {
        isActive = true;
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
