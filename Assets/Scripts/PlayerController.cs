using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public GameObject bulletPrefab;
    public Vector3 offsetValue;
    public int health = 100;
    public Text heathText;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * playerSpeed * inputY * Time.deltaTime);
        transform.Translate(Vector3.right * playerSpeed * inputX * Time.deltaTime);
        if (transform.position.y > 4.5f)
        {
            transform.position = new Vector3(transform.position.x, 4.5f, 0);
        }
        else if (transform.position.y < -4.5f)
        {
            transform.position = new Vector3(transform.position.x, -4.5f, 0);
        }
        if (transform.position.x > 7f)
        {
            transform.position = new Vector3(7f, transform.position.y, 0);
        }
        else if (transform.position.x < -7f)
        {
            transform.position = new Vector3(-7f, transform.position.y, 0);
        }
        //float movement;
        //movement = Input.GetAxis("Horizontal") * playerSpeed;
        //transform.Translate(0, -movement * Time.deltaTime, 0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletFromPool = ObjectPool.Instance.GetObjectsFromPool("Bullet");
            bulletFromPool.transform.position = this.transform.position + offsetValue;
            bulletFromPool.SetActive(true);
        }

        heathText.text = health.ToString();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Astroid")
        {
            health = Mathf.Clamp(health - 10, 0, 100);
            Debug.Log("Health : " + health);
            //heathText.text = health.ToString();
            //collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "HealthKit")
        {
            health = Mathf.Clamp(health + 50, 0, 100);
        }
    }
   
   
  
}