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
    private Transform centerPoint; // �emberlerin merkez noktas�
    [SerializeField]
    private float innerRadius; // �� �emberin yar��ap�
    [SerializeField]
    private float outerRadius; // D�� �emberin yar��ap�
    [SerializeField]
    private float spawnInterval; // Nesne olu�turma aral��� (saniye)

    private float spawnTimer; // Nesne olu�turma zamanlay�c�s�

    private void Update()
    {
        spawnTimer += Time.deltaTime;

        // Belirli bir zaman aral���nda nesne olu�turma
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
        // Rastgele bir nokta se�me
        Vector2 randomPoint = Random.insideUnitCircle.normalized;
        Vector3 spawnPosition = new Vector3(randomPoint.x, 0f, randomPoint.y) * Random.Range(innerRadius, outerRadius);

        // Nesneyi olu�turma
        Instantiate(RandomTarget(Random.Range(1,4)), centerPoint.position + spawnPosition, Quaternion.identity);
    }
}
