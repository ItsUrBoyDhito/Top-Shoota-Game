using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Slagskamp : MonoBehaviour
{
    public int SlagskampRisk;

    void Start()
    {
        int slumpatTal = Random.Range(0, 100);

        if (slumpatTal <= SlagskampRisk)
        {
            SceneManager.LoadScene(17);
        }
    }
}
