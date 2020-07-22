using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
