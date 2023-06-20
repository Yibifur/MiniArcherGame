using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TargetDeath : MonoBehaviour
{
    
    [SerializeField]
    private float deathDuration;
    private GameObject player;
    private ParticleSystem explosion;
    private AudioSource audioSource;
    private AudioClip audioClip;
    private GameObject scoreHolderObj;
    private ScoreHolder scoreHolder;
    private int score;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        scoreHolderObj = GameObject.FindGameObjectWithTag("ScoreHolderObj");
        explosion=GetComponentInChildren<ParticleSystem>();
        audioSource=GetComponent<AudioSource>();
        audioClip = audioSource.clip;
        explosion.gameObject.SetActive(false);
        scoreHolder=scoreHolderObj.GetComponent<ScoreHolder>();
        score=scoreHolder.GetScore();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Arrow")
        {
            if(gameObject.tag == "25Puan")
            {
               score=0+ (int)(25 * Vector3.Distance(gameObject.transform.position, player.transform.position) / 100); 
            }
            else if (gameObject.tag == "50Puan")
            {
                score =0+ (int)(50 * Vector3.Distance(gameObject.transform.position, player.transform.position) / 100);
            }
            else if ( gameObject.tag == "100Puan")
            {
                score =0+ (int)(100 * Vector3.Distance(gameObject.transform.position, player.transform.position) / 100);
            }
            scoreHolder.SetScore(score);
            explosion.gameObject.SetActive(true);
            audioSource.PlayOneShot(audioClip);
            Invoke("DestroyObj", deathDuration);
            Destroy(collision.gameObject);


            
        }
       
    }

    private void Update()
    {
        
         
    }
    private void DestroyObj()
    {
            Destroy(gameObject);
    }


    
}