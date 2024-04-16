using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] bool IsActive;
    [SerializeField] GameObject Activate;

    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Activate.SetActive(!IsActive);
        }
    }

    public void Reset()
    {
        Activate.SetActive(IsActive);
    }
}
