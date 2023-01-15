using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isCollidingWith : MonoBehaviour
{
    public bool isChicken = false;
    public bool isGinger = false;
    public bool isSonion = false;

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
        if (collision.gameObject.tag == "chicken")
        {
            isChicken = true;
        }
        else if (collision.gameObject.name == "cut ginger")
        {
            isGinger = true;
        }
        else if (collision.gameObject.name == "cut onion")
        {
            isSonion = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "chicken")
        {
            isChicken = false;
        }
        else if (collision.gameObject.name == "cut ginger")
        {
            isGinger = false;
        }
        else if (collision.gameObject.name == "cut onion")
        {
            isSonion = false;
        }
    }
}