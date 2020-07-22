using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 30;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = Vector2.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Wall")
        {
            Destroy(gameObject);
        }
        else if (coll.tag == "Aliens")
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
