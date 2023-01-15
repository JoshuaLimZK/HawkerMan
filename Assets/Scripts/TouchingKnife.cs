using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TouchingKnife : MonoBehaviour
{
    // Start is called before the first frame update
    public int cutProgress = 0;

    public GameObject springOnion;
    public GameObject springOnionPart01;
    public GameObject springOnionPart02;
    public XRDirectInteractor Rhand;
    public XRDirectInteractor Lhand;
    public XRGrabInteractable knife1;
    public XRGrabInteractable knife2;

    private void Start()
    {
        springOnionPart01.SetActive(false);
        springOnionPart02.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Knife")
        {
            if (Lhand.interactablesSelected.Contains(knife1) || Rhand.interactablesSelected.Contains(knife1)
                || Lhand.interactablesSelected.Contains(knife2) || Rhand.interactablesSelected.Contains(knife2))
            {
                Debug.Log($"cutProgress = {cutProgress}");
                cutProgress++;
            }
            //Debug.Log($"CutProgress = {cutProgress}");

            if (cutProgress == 1)
            {
                springOnionPart01.SetActive(true);
                springOnionPart02.SetActive(true);

                //Debug.Log("Knife cut");

                springOnionPart01.transform.position = springOnion.transform.position;
                springOnionPart02.transform.position = springOnion.transform.position;

                Destroy(springOnion);
            }
        }
    }
}