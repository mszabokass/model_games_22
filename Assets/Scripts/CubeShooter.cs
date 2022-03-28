using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShooter : MonoBehaviour
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


        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(hit.normal * (hit.transform.position.x < 0 ? 1 : -1), ForceMode.Impulse);
            }
        }
    }
}
