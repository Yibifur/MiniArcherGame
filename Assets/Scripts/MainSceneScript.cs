using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        Debug.Log("OYUN BAÞLIYOR");
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Debug.Log("OYUNDAN ÇIKIIYOR");
       Application.Quit();
    }
}
