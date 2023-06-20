using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class GameStopper : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        pause = !pause;
    }
    [SerializeField] private Image UIfill;
    [SerializeField] private Text UItext;
    [SerializeField] private int duration;
    private bool pause;
    [SerializeField] private int remainingDuration;

    private void Start()
    {
        Being(duration);
    }
    private void Being(int second)
    {
remainingDuration= second;
        StartCoroutine(UpdateTimer()); 
    }
    IEnumerator UpdateTimer()
    {
       
        while(remainingDuration > 0) { 
            if (!pause)
        {
             UItext.text = $"{remainingDuration / 60:00}:{remainingDuration % 60:00}";
            UIfill.fillAmount= Mathf.InverseLerp(0,duration,remainingDuration);
            remainingDuration--;
                yield return new WaitForSeconds(1f);
            }
            
            yield return null;
        }
        OnEnd(); 
    }

    private void Update()
    {
        if(remainingDuration<=0)
        {
            SceneManager.LoadScene(2);
        }
    }
    private void OnEnd()
    {
       
        
    }
}
