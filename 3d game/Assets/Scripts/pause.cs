using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Cinemachine;

public class pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public CinemachineVirtualCamera camera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else 
            {
                Pause();
            }
        }
    }

    void Resume()
    { 
        PauseMenuUI.SetActive(false);
        camera.enabled = true;
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        camera.enabled = false;
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
