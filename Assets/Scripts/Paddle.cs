using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float speed = 10.0f;
    public Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

}
