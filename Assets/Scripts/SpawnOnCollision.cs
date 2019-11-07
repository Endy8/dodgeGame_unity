using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    bool spawnSelf;

    [SerializeField]
    GameObject gameObjectSpawn;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == strTag)
        {
            if(spawnSelf)
                Instantiate(gameObjectSpawn, transform.position,Quaternion.identity);
            else
                Instantiate(gameObjectSpawn, collision.transform.position,Quaternion.identity);
        }
    }
}

