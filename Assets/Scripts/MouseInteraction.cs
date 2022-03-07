using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteraction : MonoBehaviour
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

        if(Physics.Raycast(ray, out hit) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(new Vector3(-2.74f, 1f, 0), ForceMode.Impulse);
        }

    }
}
