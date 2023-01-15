using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfComplete : MonoBehaviour
{
    public bool gotCucumber = false;
    public bool gotRice = false;
    public bool gotChicken = false;
    public bool done = false;
    public CheckIfCooked cookRice;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (gotCucumber && gotRice && gotChicken && cookRice.cooked)
        {
            done = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cucumber")
        {
            gotCucumber = true;
        }
        if (collision.gameObject.tag == "chicken")
        {
            gotChicken = true;
        }
        if (collision.gameObject.tag == "rice")
        {
            gotRice = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "cucumber")
        {
            gotCucumber = true;
        }
        if (collision.gameObject.tag == "chicken")
        {
            gotChicken = true;
        }
        if (collision.gameObject.tag == "rice")
        {
            gotRice = true;
        }
    }
}