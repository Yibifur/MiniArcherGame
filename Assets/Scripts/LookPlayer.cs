using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    
    private Transform playerTransform; // Oyuncunun Transform bileþeni
    public Vector3 offset;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
       
        transform.LookAt(playerTransform.position);
        transform.rotation *= Quaternion.Euler(offset);
    }
}
