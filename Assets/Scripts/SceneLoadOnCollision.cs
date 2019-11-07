using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    string strScene;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == strTag)
            SceneManager.LoadScene(strScene);
    }
}

