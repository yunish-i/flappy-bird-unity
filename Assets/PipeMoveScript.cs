using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 20;
    public float deadZone = -65;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone) {
            Debug.Log("Pipe is out of bounds");
            Destroy(gameObject);
        }
    }

}
