using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] List<GameObject> Levels;
    public int LevelCount;

    private GameObject Level;
    private GameObject PrevLevel;

    // Start is called before the first frame update
    void Start()
    {
        Loadlevel();
    }

    public void Loadlevel()
    {

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
        Loadlevel();
    }
}
