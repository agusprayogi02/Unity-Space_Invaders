using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            SoundManager.Instance.PlayOneShot(SoundManager.Instance.alienDies);
            IncreaseTextUIScore();
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void IncreaseTextUIScore()
    {
        var UiText = GameObject.Find("Score").GetComponent<Text>();
        int score = int.Parse(UiText.text);
        score += 10;
        UiText.text = score.ToString();
    }
}
