using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinController : MonoBehaviour
{
    [SerializeField] GameObject LevelController; 
    private LevelController NextLevel;

    // Start is called before the first frame update
    void Start()
    {
        NextLevel = LevelController.GetComponent<LevelController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = new Vector3(-0.5f, 1f, -0.5f);
            NextLevel.NextLevel();
        }
    }
}
