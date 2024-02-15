using System.Collections;
using UnityEngine;

public class SpawnObjectsWithDeltaTime : MonoBehaviour
{
    [SerializeField] public GameObject[] spawningObjects; // one or more prefabs to spawn
    public float spawnInterval = 0.5f; // interval between spawns
    public float leftMargin = -2;
    public float rightMargin = 2;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer -= spawnInterval; // reset timer for accurate timing
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        var spawnPositionX = Random.Range(leftMargin, rightMargin); // spawn position on X
        var position = new Vector3(spawnPositionX, transform.position.y); // spawn position on Y == object position
        var instantiatedObject = Instantiate(spawningObjects[Random.Range(0, spawningObjects.Length)], position, Quaternion.identity);
        Destroy(instantiatedObject, 5f);
    }
}