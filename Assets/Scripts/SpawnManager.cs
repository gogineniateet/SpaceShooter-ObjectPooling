using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public GameObject astroidPrefab;
    public float time;
    public float time1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > 3f)
        {
            GameObject astroidFromPool = ObjectPool.Instance.GetObjectsFromPool("Astroid");
            astroidFromPool.transform.position = new Vector3(this.transform.position.x, Random.Range(-4f, 4f), 0f);
            astroidFromPool.SetActive(true);
            time = 0f;
        }
        time1 = time1 + Time.deltaTime;
        if (time1 > 3f)
        {
            GameObject astroidFromPool = ObjectPool.Instance.GetObjectsFromPool("Health");
            astroidFromPool.transform.position = new Vector3(this.transform.position.x, Random.Range(-4f, 4f), 0f);
            astroidFromPool.SetActive(true);
            time1 = 0f;
        }

    }

}

