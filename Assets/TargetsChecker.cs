using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetsChecker : MonoBehaviour
{
    public List<GameObject> targets;

    private void Update()
    {
        bool everyoneDead = true;
        foreach (var g in targets)
        {
            if (g.activeSelf)
            {
                everyoneDead = false;
            }
        }

        if (everyoneDead)
            UnityEngine.SceneManagement.SceneManager.LoadScene("WinScene");
    }
}
