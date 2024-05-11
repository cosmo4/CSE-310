using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -20;

    // Update is called once per frame
    void Update()
    {
        // move pipe across screen
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        // destroy pipe once it gets to a certain position off screen
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
