using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject info;

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

    public void Info()
    {
        menu.SetActive(false);
        info.SetActive(true);
    }

    public void Menu()
    {
        menu.SetActive(true);
        info.SetActive(false);
    }
}
