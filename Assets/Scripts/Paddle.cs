using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float speed = 8.0f;
    public new Rigidbody2D rigidbody { get; private set; } 

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
         
       // _rigidbody.position = Vector2.zero;
        
        rigidbody.position = new Vector2(rigidbody.position.x, 0.0f);
       
    }

}
