using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float BounceStrength;
    private void OnCollisionEnter2D(Collision2D collision2D) {
        Ball ball = collision2D.gameObject.GetComponent<Ball>();
        if (ball != null) {
            Vector2 normal = collision2D.GetContact(0).normal;
            ball.AddForce(-normal * this.BounceStrength);
        }
    }
}
