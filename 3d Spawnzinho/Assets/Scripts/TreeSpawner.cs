using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject treePrefab;   // árvore a ser spawnada
    public float spawnInterval = 2f; // intervalo entre árvores
    public float radius = 5f;        // área de spawn

    void Start()
    {
        InvokeRepeating("SpawnTree", 1f, spawnInterval);
    }

    void SpawnTree()
    {
        Vector3 randomPos = transform.position + Random.insideUnitSphere * radius;
        randomPos.y = transform.position.y; // mantém no chão

        Instantiate(treePrefab, randomPos, Quaternion.identity);
    }
}
