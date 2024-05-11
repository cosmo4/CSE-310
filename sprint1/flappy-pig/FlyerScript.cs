using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyerScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool pigIsAlive = true;
    public float rotationSpeed = 400f;
    public float margin = 0.1f;

    public AudioSource src;
    public AudioClip wingFlap, oink;

    private float minYposition;
    private float maxYposition;


    // Start is called before the first frame update
    void Start()
    {
        // Link the Logic Script Game Object
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        // Set the pigs location boundaries
        float halfHeight = Camera.main.orthographicSize;
        minYposition = -halfHeight + margin;
        maxYposition = halfHeight - margin;
    }

    // Update is called once per frame
    void Update()
    {
        // Verify the pig is alive and in bounds before allowing it to jump
        if (Input.GetKeyDown(KeyCode.Space) && pigIsAlive && (transform.position.y < maxYposition))
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            // Audio for jumping
            src.clip = wingFlap;
            src.Play();
            
        }
        else if (!pigIsAlive)
        {
            // Rotation animation upon game over
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.Rotate(0, 0, rotationAmount);
        }
        // end game if pig goes out of bounds
        if (transform.position.y < (minYposition - 0.5f) || transform.position.y > (maxYposition + 3f))
        {
            endGame();
        }

        
    }

    private void endGame()
    {
        logic.gameOver();
        pigIsAlive = false;
        
        // sound when the pig dies
        src.clip = oink;
        src.Play();
    }
    // senses for collision with pipes
    private void OnCollisionEnter2D(Collision2D collision)
    {
        endGame();
    }

}
