using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour
{

    float force = 300;

    void OnCollisionEnter(Collision col)
    {

        Vector3 forceDir = this.transform.forward;

       // if (col.gameObject.tag == "Ball")
        //{
            col.gameObject.GetComponent<Rigidbody>().AddForce(-forceDir*force);
        //}
    }


}
