using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFreeze : MonoBehaviour
{

    public Material materialIce;
    public Material materialRed;

    private Vector3 origPos;
    private Vector3 origRot;

    void Setup()
    {

        origPos = this.gameObject.transform.position;

    }

    private void Update()
    {
        if(this.gameObject.transform.position == origPos)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materialIce;
        }
        else
            this.gameObject.GetComponent<MeshRenderer>().material = materialRed;
    }



    //void OnCollisionEnter(Collision col)
    //{

    //    if (col.gameObject.tag == "Ball_blue")
    //    {

    //        //col.gameObject.GetComponent<MeshRenderer>().material = material1;

    //        this.gameObject.GetComponent<MeshRenderer>().material = materialBlue;
    //        this.tag = "Blue";

    //    }

    //    if (col.gameObject.tag == "Ball_red")
    //    {

    //        //col.gameObject.GetComponent<MeshRenderer>().material = material1;

    //        this.gameObject.GetComponent<MeshRenderer>().material = materialRed;
    //        this.tag = "Red";

    //    }


    //}




}
