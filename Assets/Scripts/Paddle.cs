using UnityEngine;

public class Paddle : MonoBehaviour
{
       protected Rigidbody2D rigidBody2D;
       public float speed = 10.0f;
       private void Awake() {
              rigidBody2D = GetComponent<Rigidbody2D>();
       }

       public void ResetPosition() {
              rigidBody2D.position = new Vector2(rigidBody2D.position.x, 0.0f);
              rigidBody2D.linearVelocity = Vector2.zero;
       }
}
