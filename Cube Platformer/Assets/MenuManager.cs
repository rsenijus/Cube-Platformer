using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void NewGame()
    {
        PlayerPrefs.SetInt("LevelCount", 0);
        PlayerPrefs.Save();
        LoadGame();
    }
}
