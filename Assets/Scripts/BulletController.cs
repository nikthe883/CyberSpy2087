using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;

    public Rigidbody myRigitBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletFly()
    }
    private void BulletFly()
    {
        myRigitBody.velocity = transform.forward * speed;
    }
}
