using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;

    public Vector3 spawnPoint;

    private void Start()
    {

        InvokeRepeating(nameof(SpawnPipe), 0, 4);

    }

    private void SpawnPipe()

    {

        Instantiate(pipe, spawnPoint + Vector3.up * Random.Range(-0.5f, 3.5f), Quaternion.identity);

    }

}
