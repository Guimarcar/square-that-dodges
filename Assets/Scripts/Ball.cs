using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool isRight;
    public float speed;

    public Transform pointR;
    public Transform pointL;

    void Start()
    {
        
    }

    void Update()
    {
        if (isRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0))
        {
            isRight = !isRight;
        }

        if(Vector2.Distance(transform.position, pointL.position) < 0.2f)
        {
            isRight = true;
        }
        else if (Vector2.Distance(transform.position, pointR.position) < 0.2f)
        {
            isRight = false;
        }
    }
}
