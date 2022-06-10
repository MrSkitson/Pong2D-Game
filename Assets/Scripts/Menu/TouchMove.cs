using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Touch();
    }

     void Touch()
    {

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(mousePos.y > 1)
            {
                //Move right
                transform.Translate(0, moveSpeed, 0);
            }
            else if(mousePos.y < -1)
            {
                //move left
                transform.Translate(0, -moveSpeed, 0);
            }
        } 

    }
}
