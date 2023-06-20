using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public GameObject leftHand;
    public Animator handAnimator;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    float triggerValue;
    float gripValue;
    // Update is called once per frame
    void Update()
    {
        triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);
        //Debug.Log("trigger Value:"+triggerValue);
         gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
        //Debug.Log("grip value:"+gripValue);
       
    }
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "AttachPointTag")
        {
            gripAnimationAction.action.Reset();
            Debug.Log("GÝRDÝ MÝ");
            triggerValue = 0f;
            gripValue = 1f;
            handAnimator.SetFloat("Trigger", triggerValue);

            handAnimator.SetFloat("Grip", gripValue);
        }    
    }
    private void changeHandRotation()
    {
        leftHand.transform.rotation = Quaternion.Euler(0, 22.5f, 90);
    }
}
