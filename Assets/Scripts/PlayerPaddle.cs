
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 direction;

    private void Update()
    {
        //Input System 
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            direction = Vector2.down;
        } else {
            direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(direction * this.speed);
        }
    }

}
