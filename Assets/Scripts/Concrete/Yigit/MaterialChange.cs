using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using System;

public class MaterialChange : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject rightHand;
    public Material glovesMaterial;
    private bool x;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Left Hand" || other.gameObject.tag == "Right Hand")
        {
            Debug.Log("girdim");
            
            x = true;
            leftHand.GetComponent<SkinnedMeshRenderer>().material = glovesMaterial;
            rightHand.GetComponent<SkinnedMeshRenderer>().material = glovesMaterial;
        }
        else { x = false; Debug.Log("giasssaardim"); }
    }
    private void Update()
    {
        Debug.Log(x);
    }


}
