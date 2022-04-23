using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private PsychoController psychoController;
    [SerializeField] private ObjectsScripter objectsScripter;
    [SerializeField] private DialogScripter dialogScripter;
    [SerializeField] private UIScripter uiScripter;
    [SerializeField] private MusicManager musicManager;
    //[SerializeField] private MusicScriptManager scriptMusic;

    private float time;
    private void Start()
    {
        time = Time.time;
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        if (!psychoController.isLive && objectsScripter.isActive)
        {
            psychoController.enabled = false;
            objectsScripter.isActive = false;
            dialogScripter.enabled = false;
            //doctorNavMesh.enabled = false;

            musicManager.StopMusic();
            musicManager.EndGame();
            uiScripter.EndGame();

            this.enabled = false;
        }
    }
}
