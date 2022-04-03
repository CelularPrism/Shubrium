using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public class DialogScripter : MonoBehaviour
{
    [SerializeField] private GameObject dialogGameObject;
    [SerializeField] private GameObject dialogChangerGameObject;

    private List<DialogInterface> dialogInterfaces;
    private DialogManager dialogManager;

    private void Start()
    {
        dialogManager = dialogGameObject.GetComponent<DialogManager>();

        var list = from t in Assembly.GetExecutingAssembly().GetTypes()
                   where t.GetInterfaces().Contains(typeof(DialogInterface))
                            && t.GetConstructor(System.Type.EmptyTypes) != null
                   select System.Activator.CreateInstance(t) as DialogInterface;
        dialogInterfaces = list.ToList();
    }

    private void Update()
    {
        /*if (Input.anyKeyDown && !dialogGameObject.activeSelf)
            SetNewDialog();*/
    }

    public void SetNewDialog()
    {
        if (dialogInterfaces.Count > 0)
        {
            int random = Random.Range(0, dialogInterfaces.Count);
            DialogInterface dialog = dialogInterfaces[random];

            if (!dialog.GetDialog().haveVariants)
            {
                dialogGameObject.transform.GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                dialogGameObject.transform.GetChild(0).gameObject.SetActive(true);
            }

            dialogGameObject.SetActive(true);

            dialogChangerGameObject.SetActive(true);
            dialogManager.SetDialog(dialog);

            dialogInterfaces.Remove(dialog);
        }
    }
}
