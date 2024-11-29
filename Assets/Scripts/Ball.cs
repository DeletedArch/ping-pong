using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    private Rigidbody2D rigidbody2D;

    private void Awake() {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Start() {
        ResetPosition();
        AddStartingForce();
    }
    
    public void ResetPosition() {
        rigidbody2D.position = Vector2.zero;
        rigidbody2D.linearVelocity = Vector2.zero;
    }

    public void AddStartingForce() {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : 
                                        Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        rigidbody2D.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force) {
        rigidbody2D.AddForce(force);
    }

    
}
