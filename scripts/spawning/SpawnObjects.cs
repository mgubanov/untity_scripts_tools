using System.Collections;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] public GameObject[] spawningObjects; // one or more prefabs to spawn
    public float spawnTimeout = 0.5f; //lower number means faster spawn
    public float leftMargin = -2;
    public float rightMargin = 2;
    
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            var spawnPositionX = Random.Range(leftMargin, rightMargin);// spawn position on X
            var position = new Vector3(spawnPositionX, transform.position.y); // spawn position on Y == object position
            var instantiate = Instantiate(spawningObjects[Random.Range(0, spawningObjects.Length)], position,
                Quaternion.identity);
            yield return new WaitForSeconds(spawnTimeout);
            Destroy(instantiate, 5f);
        }
    }
}
