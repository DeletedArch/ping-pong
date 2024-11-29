using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    private void FixedUpdate() {
        if (this.ball.linearVelocityX > 0.0f) {
            if (this.ball.position.y > this.transform.position.y) {
                rigidBody2D.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < this.transform.position.y) {
                rigidBody2D.AddForce(Vector2.down * this.speed);
            }
        } else {
            if (this.transform.position.y > 0.0f) {
                rigidBody2D.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f) {
                rigidBody2D.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
