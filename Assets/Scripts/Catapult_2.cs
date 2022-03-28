using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult_2 : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Ball")
        {
        col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 16, 0));
        }
    }


}
