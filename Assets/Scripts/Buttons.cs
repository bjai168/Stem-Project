using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1 (Part 1)");
    }

    public void OpenLevels()
    {
        Debug.Log("Levels opened!");
    }

    public void Credits()
    {
        Debug.Log("Credits");
    }
}
