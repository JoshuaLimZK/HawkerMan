using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateGrabRay : MonoBehaviour
{
    public GameObject leftGrabRay;
    public GameObject rightGrabRay;

    public XRDirectInteractor leftHand;
    public XRDirectInteractor rightHand;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        leftGrabRay.SetActive(leftHand.interactablesSelected.Count == 0);
        rightGrabRay.SetActive(rightHand.interactablesSelected.Count == 0);
    }
}