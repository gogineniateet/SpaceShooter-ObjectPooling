using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    //public float bulletSpeed;
    ScoreManager score;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Astroid")
        {
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);
            score.ScoreUpdate(10);
        }

    }

}
