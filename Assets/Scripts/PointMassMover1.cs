using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMassMover1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);



        //if (Input.GetMouseButton(0))
        //{
        if (Physics.Raycast(ray, out hit) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(new Vector3(0, 1, 0), ForceMode.Impulse);
        }
        //}

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.rigidbody != null)
            {
                //Vector3 direction = hit.transform.position - hit.point;
                hit.rigidbody.AddRelativeForce(new Vector3(0, 0, 1), ForceMode.Impulse);
                //hit.rigidbody.AddForce(hit.normal * (hit.transform.gameObject.tag == "WhiteCube" ? 1 : -1), ForceMode.Impulse);
            }
        }
    }
}
