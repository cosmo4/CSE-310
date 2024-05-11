using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 3;

    // call one pipe right at the start
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // add to timer until its time to spawn another pipe
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // set height for the spawn pipe randomly, within the screen limits
        Instantiate(Pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
