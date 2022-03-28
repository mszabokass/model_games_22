using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public Material materialBlue;
    public Material materialRed;

    private Vector3 origPos;

    void Setup()
    {


        origPos = this.gameObject.transform.position;

    }

    

    


    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Ball_blue")
        {

            //col.gameObject.GetComponent<MeshRenderer>().material = material1;

            this.gameObject.GetComponent<MeshRenderer>().material = materialBlue;
            this.tag = "Blue";

        }

        if (col.gameObject.tag == "Ball_red")
        {

            //col.gameObject.GetComponent<MeshRenderer>().material = material1;

            this.gameObject.GetComponent<MeshRenderer>().material = materialRed;
            this.tag = "Red";

        }


    }


}
