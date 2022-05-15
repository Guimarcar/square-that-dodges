using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;
    public AudioSource audioCoin;

    void Start()
    {
        transform.Rotate(0, 0, Random.Range(-110, -70));
    }

    void FixedUpdate()
    {
        rig.MovePosition(transform.position + transform.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.instance.AddScore();
            //Destroy(gameObject);
            audioCoin.Play();
        }
    }
}
