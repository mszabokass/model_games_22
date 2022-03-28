using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsCreateBall : MonoBehaviour
{

    public Object blueBall;
    public Object redBall; 
    public Object orangeBall;

    public Material materialRed;
    public Material materialBlue;


    void OnCollisionEnter(Collision col)
    {
        
        Vector3 spawnHere = col.transform.position;

        if (this.gameObject.tag == "Ball_red" && col.gameObject.tag == "Ball_orange")
        {
                        
            col.gameObject.GetComponent<MeshRenderer>().material = materialRed;
            col.gameObject.tag = "Ball_red";

            //Instantiate(orangeBall, spawnHere, col.transform.rotation);

        }

        if (this.gameObject.tag == "Ball_blue" && col.gameObject.tag == "Ball_orange")
        {

            col.gameObject.GetComponent<MeshRenderer>().material = materialBlue;
            col.gameObject.tag = "Ball_blue";

            //Instantiate(orangeBall, spawnHere, col.transform.rotation);

        }


    }
}
