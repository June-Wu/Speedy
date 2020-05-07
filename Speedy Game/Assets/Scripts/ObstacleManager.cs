using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] obstaclePrefab;
    private int spawnProbability = 10;
    private int z_Offset = 0;

    // Update is called once per frame
    void Update()
    {
        SpawnObstacle();
    }

    private void SpawnObstacle()
    {
        if (Random.Range(0, 100) > spawnProbability)
        {
            Vector3 position = new Vector3(Random.Range(-24,25), 10, z_Offset);
            Quaternion rotation = Quaternion.Euler(Random.Range(0, 180), Random.Range(0, 180), Random.Range(0, 180));
            z_Offset += Random.Range(0, 50);
            GameObject obstacleClone = Instantiate(obstaclePrefab[Random.Range(0, obstaclePrefab.Length)], position, rotation);
            obstacleClone.transform.localScale = Vector3.one * Random.Range(1, 10);
        }
    }
}
