using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    [SerializeField]
    Transform transTowards;

    [SerializeField]
    float fSpeed;

    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if(transTowards == null)
        {
            transTowards = FindObjectOfType<AddPlayerControlledVelocity>().transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity += (transTowards.position - transform.position).normalized * fSpeed * Time.deltaTime;
    }
}
