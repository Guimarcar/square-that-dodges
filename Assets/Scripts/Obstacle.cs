using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;
    public AudioSource audioDeath;

    void Start()
    {
        transform.Rotate(0, 0, Random.Range(-135, -45));
    }

    void FixedUpdate()
    {
        rig.MovePosition(transform.position + transform.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            audioDeath.Play();
            GameController.instance.ShowGameOver();
        }
    }
}
