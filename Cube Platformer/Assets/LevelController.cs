using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelController : MonoBehaviour
{
    [SerializeField] List<GameObject> Levels;
    public int LevelCount = 0;

    private GameObject Level;
    private GameObject PrevLevel;

    [SerializeField] TMP_Text LevelCountUI;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("LevelCount", 0);
        //PlayerPrefs.Save();
        if (PlayerPrefs.HasKey("LevelCount"))
        {
            LevelCount = PlayerPrefs.GetInt("LevelCount");
        }
        Loadlevel();
    }

    public void Loadlevel()
    {
        LevelCountUI.text = LevelCount + " Level";
        if (LevelCount != 0)
        {
            PrevLevel = Levels[LevelCount - 1];
            PrevLevel.SetActive(false);
        }
        Level = Levels[LevelCount];
        Level.SetActive(true);
    }

    public void NextLevel()
    {
        LevelCount++;
        PlayerPrefs.SetInt("LevelCount", LevelCount);
        PlayerPrefs.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
