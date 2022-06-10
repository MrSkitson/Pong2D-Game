using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncSurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.rigidbody.AddForce(-normal * bounceStrength, ForceMode2D.Impulse);
        }
    }

}
