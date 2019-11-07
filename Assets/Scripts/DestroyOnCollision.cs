using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    bool destroySelf;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == strTag)
        {
            if(destroySelf)
                Destroy(this.gameObject);
            else
                Destroy(collision.gameObject);
        }
    }
}

