using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject oneHundredPointstarget;
    [SerializeField]
    private GameObject fiftyPointstarget;
    [SerializeField]
    private GameObject twentyFivePointstarget;
    [SerializeField]
    private Transform centerPoint; // Çemberlerin merkez noktasý
    [SerializeField]
    private float innerRadius; // Ýç çemberin yarýçapý
    [SerializeField]
    private float outerRadius; // Dýþ çemberin yarýçapý
    [SerializeField]
    private float spawnInterval; // Nesne oluþturma aralýðý (saniye)

    private float spawnTimer; // Nesne oluþturma zamanlayýcýsý

    private void Update()
    {
        spawnTimer += Time.deltaTime;

        // Belirli bir zaman aralýðýnda nesne oluþturma
        if (spawnTimer >= spawnInterval)
        {
            SpawnObject();
            spawnTimer = 0f;
        }
    }
    private GameObject RandomTarget(float value)
    {
        if (value == 3f)
        {
            return oneHundredPointstarget;
        }
        else if (value == 2f)
        {
            return fiftyPointstarget;
        }
        else if(value==1f)
        {
            return twentyFivePointstarget;
        }
        else
        {
            return null;
        }
    }
    private void SpawnObject()
    {
        // Rastgele bir nokta seçme
        Vector2 randomPoint = Random.insideUnitCircle.normalized;
        Vector3 spawnPosition = new Vector3(randomPoint.x, 0f, randomPoint.y) * Random.Range(innerRadius, outerRadius);

        // Nesneyi oluþturma
        Instantiate(RandomTarget(Random.Range(1,4)), centerPoint.position + spawnPosition, Quaternion.identity);
    }
}
