using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DetectShakeRice : MonoBehaviour
{
    public GameObject shaker;
    public bool colliding = false;
    public bool shaken = false;

    // Start is called before the first frame update
    private void Start()
    {
        XRGrabInteractable grabble = GetComponent<XRGrabInteractable>();
        grabble.activated.AddListener(Shake);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "riceCooker")
        {
            colliding = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "riceCooker")
        {
            colliding = false;
        }
    }

    public void Shake(ActivateEventArgs args)
    {
        if (shaker.transform.up.y < 0)
        {
            if (colliding)
            {
                shaken = true;
                Debug.Log("shaken");
            }
        }
    }
}