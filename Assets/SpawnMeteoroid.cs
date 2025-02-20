using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteoroid : MonoBehaviour
{
    [SerializeField] private GameObject meteoPrefab;
    private Vector3 spawnPoint;
    private int randonNumber;
    Coroutine co;

    private void Start()
    {
        co = StartCoroutine("SpawnMeteo");
    }
    public void StopSpawn()
    {
        StopCoroutine(co);
    }
    private void SetPos()
    {
        randonNumber = Random.Range(0, 3);
        switch(randonNumber)
        {
            case 0:
                spawnPoint.x = Random.Range(-11.0f, 11.0f);
                spawnPoint.y = Random.Range(-8.0f, -6.0f);
                spawnPoint.z = 0;
                break;
            case 1:
                spawnPoint.x = Random.Range(-11.0f, 11.0f);
                spawnPoint.y = Random.Range(6.0f, 8.0f);
                spawnPoint.z = 0;
                break;
            case 2:
                spawnPoint.x = Random.Range(9.0f, 11.0f);
                spawnPoint.y = Random.Range(-8.0f, 8.0f);
                spawnPoint.z = 0;
                break;
            case 3:
                spawnPoint.x = Random.Range(-11.0f, -9.0f);
                spawnPoint.y = Random.Range(-8.0f, 8.0f);
                spawnPoint.z = 0;
                break;
            default:
                break;
        }
        Debug.Log(spawnPoint);
    }
    IEnumerator SpawnMeteo()
    {
        while (true)
        {
            SetPos();
            Instantiate(meteoPrefab, spawnPoint, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
