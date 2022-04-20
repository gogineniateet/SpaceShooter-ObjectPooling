using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObjectDestroy : MonoBehaviour
{
    public void OnBecameInvisible()
    {
        ObjectPool.Instance.BackToPool(gameObject);
    }
}
