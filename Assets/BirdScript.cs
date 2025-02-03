using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive) {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        logic.endGame();
        birdIsAlive = false;

    }
}
