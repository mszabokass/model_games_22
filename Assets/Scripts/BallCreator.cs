using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    public Object blueBall;
    public Object redBall;
    public Object orangeBall;

    public GameObject copy;


    void OnCollisionEnter(Collision col)
    {
        Vector3 spawnHere = col.transform.position - new Vector3(0,1,0);

        if ((col.gameObject.tag == "Ball_blue" && this.tag == "WhiteCube") || (col.gameObject.tag == "Ball_blue" && this.tag == "Blue"))
        {

            copy = (GameObject)Instantiate(blueBall, spawnHere, col.transform.rotation);
            copy.tag = "Ball_blue";
            this.tag = "Blue";

        }

        if ((col.gameObject.tag == "Ball_red" && this.tag == "WhiteCube") || (col.gameObject.tag == "Ball_red" && this.tag == "Red"))
        {          
            //col.gameObject.GetComponent<MeshRenderer>().material = material1;

            copy = (GameObject)Instantiate(redBall, spawnHere, col.transform.rotation);
            copy.tag = "Ball_red";
            this.tag = "Red";
        }

        if ((col.gameObject.tag == "Ball_blue" && this.tag == "Red") || (col.gameObject.tag == "Ball_red" && this.tag == "Blue"))
        {

            copy = (GameObject)Instantiate(orangeBall, spawnHere, col.transform.rotation);
            copy.tag = "Ball_orange";
            //Destroy(col.gameObject);

            if (col.gameObject.tag == "Ball_blue")
                this.tag = "Blue";
            else this.tag = "Red";

        }




    }


}
