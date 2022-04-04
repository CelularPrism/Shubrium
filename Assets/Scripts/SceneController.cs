using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private PsychoController psychoController;
    [SerializeField] private ObjectsScripter objectsScripter;
    [SerializeField] private DoctorNavMesh doctorNavMesh;
    [SerializeField] private UIScripter uiScripter;
    [SerializeField] private MusicManager musicManager;
    [SerializeField] private MusicScriptManager scriptMusic;

    private float time;
    private void Start()
    {
        time = Time.time;
    }

    void FixedUpdate()
    {
        if (!psychoController.isLive)
        {
            psychoController.enabled = false;
            objectsScripter.isActive = false;
            doctorNavMesh.enabled = false;

            musicManager.StopMusic();
            musicManager.EndGame();
            uiScripter.EndGame();

            this.enabled = false;
        }
    }
}
