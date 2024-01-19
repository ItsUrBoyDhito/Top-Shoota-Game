using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dörr : MonoBehaviour
{
    public void DraÅtHelvete(int rum)
    {
        SceneManager.LoadScene(rum);
    }
}