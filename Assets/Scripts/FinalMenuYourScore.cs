using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FinalMenuYourScore : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI yourScore;
    private GameObject scoreHolder;
    [SerializeField]
    private ScoreHolder scoreHolderComp;
    
   
    void Start()
    {
        
        scoreHolderComp = GameObject.FindGameObjectWithTag("ScoreHolderObj").GetComponent<ScoreHolder>();
        Debug.Log(scoreHolderComp.name);
        Debug.Log(scoreHolderComp.GetScore());
        yourScore.SetText($"Your Score:{scoreHolderComp.GetScore()}");
    }

   
    void Update()
    {
       
    }
}
