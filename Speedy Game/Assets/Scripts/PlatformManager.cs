using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] platformPrefabs;
    [SerializeField]
    private int z_Offset = 0;
 
    void Start()
    {
        for (int i = 0; i < platformPrefabs.Length; i++) 
        {
            Instantiate(platformPrefabs[i], new Vector3(0, 0, i * 500), Quaternion.identity);
            z_Offset += 500;
        }
    }

    public void GenerateNewPlatform()
    {
        int prefabIndex = Random.Range(0, platformPrefabs.Length);
        Instantiate(platformPrefabs[prefabIndex], new Vector3(0, 0,z_Offset), Quaternion.identity);
        z_Offset += 500;
    }
}
