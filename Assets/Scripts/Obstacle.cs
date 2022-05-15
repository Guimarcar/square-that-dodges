using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;

    void Start()
    {
        transform.Rotate(0, 0, Random.Range(-135, -45));
    }

    void FixedUpdate()
    {
        rig.MovePosition(transform.position + transform.right * speed * Time.deltaTime);
    }
}
