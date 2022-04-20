using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public GameObject astroidPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject temp = ObjectPool.Instance.GetObjectsFromPool("Asteroid");
        temp.SetActive(true);

        //if (temp!=null)
        //{
        //   temp.transform.position = this.transform.position + new Vector3(0f, Random.Range(3f, -3f), 0f);
        //   temp.SetActive(true);
        //}

    }
}

