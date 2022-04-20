using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public GameObject bulletPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement;
        movement = Input.GetAxis("Horizontal") * playerSpeed;
        transform.Translate(0, -movement * Time.deltaTime, 0f);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gameObject = ObjectPool.Instance.GetObjectsFromPool("Bullet");
            gameObject.SetActive(true);
            //Instantiate(bulletPrefab, this.transform.position, Quaternion.identity);
        }
    }
}