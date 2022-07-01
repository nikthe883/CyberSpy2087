using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed, bulletLife;

    public Rigidbody myRigitBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletFly();
        bulletLife -= Time.deltaTime;

        if(bulletLife <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void BulletFly()
    {
        myRigitBody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {   
        Destroy(gameObject);
    }
}
