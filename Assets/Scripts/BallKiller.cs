using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallKiller : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {

        if ((col.gameObject.tag == "Ball_blue") || (col.gameObject.tag == "Ball_red"))
        {

            Destroy(col.gameObject);

        }
    }
}
