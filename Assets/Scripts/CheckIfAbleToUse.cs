using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CheckIfAbleToUse : MonoBehaviour
{
    public bool useable = false;
    public GameObject lid;
    public Transform attach;
    public XRDirectInteractor Rhand;
    public XRDirectInteractor Lhand;
    public XRGrabInteractable lidobject;

    public Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (useable)
        {
            lid.transform.position = attach.position;
            lid.transform.rotation = attach.rotation;
            rb = lid.GetComponent<Rigidbody>();
            rb.useGravity = false;
        }
        else
        {
            rb.useGravity = true;
        }
        if (Lhand.interactablesSelected.Contains(lidobject) || Rhand.interactablesSelected.Contains(lidobject))
        {
            useable = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RiceLid")
        {
            useable = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "RiceLid")
        {
            useable = false;
        }
    }
}