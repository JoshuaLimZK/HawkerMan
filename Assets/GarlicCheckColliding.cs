using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlicCheckColliding : MonoBehaviour
{
    public bool isColliding;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.tag);
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "riceCooker")
        {
            isColliding = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "riceCooker")
        {
            isColliding = false;
        }
    }
}