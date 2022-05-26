using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    public new Rigidbody2D rigidbody { get; private set; }


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        //ResetPosition();
        //AddStartingForce();
    }

    public void ResetPosition()
    {
        
        rigidbody.velocity = Vector2.zero;
        rigidbody.position = Vector2.zero;
        //_rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);


    }
    public  void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);

        rigidbody.AddForce(direction * speed);
    }

   
    
}
