using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer ==0)
        {
            Debug.Log("ALGILADI");
        }
    }
}
