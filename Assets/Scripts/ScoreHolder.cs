using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolder : MonoBehaviour
{
    

    private int score;
    [SerializeField]
    private Text scoreUI;
    public int GetScore()
    {
        return score;
    }
    public void SetScore(int score)
    {
        this.score+= score;
    }


    private void Start()
    {
       DontDestroyOnLoad(this);
    }
    private void Update()
    {

        
        scoreUI.text = $"Your Score:{score}";
    }


   
}
