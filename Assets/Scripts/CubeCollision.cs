using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    public Rigidbody rb;
    public int clickForce = 500;


    // Start is called before the first frame update
    void Start()
    {
        //rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //var mouseDir = mousePos - gameObject.transform.position;
        //mouseDir.z = 0.0f;
        //mouseDir = mouseDir.normalized;

        //if (Input.GetMouseButtonDown(0))
        //{
        //    rb.AddForce(mouseDir * clickForce);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
