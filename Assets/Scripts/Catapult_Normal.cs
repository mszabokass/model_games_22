using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult_Normal : MonoBehaviour
{
    void OnCollisionEnter(Collision colObject)
    {


        Vector3 normal = -(this.transform.position - colObject.transform.position);

        //if (col.gameObject.tag == "Ball")
        //{
            colObject.gameObject.GetComponent<Rigidbody>().AddForce(normal*10, ForceMode.Impulse);
        //}
    }

}
