using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        Debug.Log("OYUN BA�LIYOR");
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Debug.Log("OYUNDAN �IKIIYOR");
       Application.Quit();
    }
}
