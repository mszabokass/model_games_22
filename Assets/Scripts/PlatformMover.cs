using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{

    float speed = 2f;
    float platformdir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        //if (transform.position.x < 25 && transform.position > -25)
        //{
        //    platformdir = 1f;
        //}
        //else 
        //{
        //    platformdir = -1f;
        //}

        //transform.Translate(Vector3(platformdir,0,0) * speed * Time.deltaTime);

        GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 0));

    }
}
