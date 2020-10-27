using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameModeToggle : MonoBehaviour
{

    public bool mode;

    public GameObject TargetPractice;
    public GameObject MeleePractice;

    private void Update()
    {
        // if (mode)
        // {
        //     if (!mode)
        //     {
        //         mode = true;
        //         TargetPractice.SetActive(false);
        //         MeleePractice.SetActive(true);
        //     }
        //     else
        //     {
        //         mode = false;
        //         TargetPractice.SetActive(true);
        //         MeleePractice.SetActive(false);
        //     }
        // }
    }

    public void ToggleGameMode()
    {
        if (!mode)
        {
            mode = true;
            TargetPractice.SetActive(false);
            MeleePractice.SetActive(true);
        }
        else
        {
            mode = false;
            TargetPractice.SetActive(true);
            MeleePractice.SetActive(false);
        }
    }
}