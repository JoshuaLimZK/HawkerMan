using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class saltParticleMaker : MonoBehaviour
{
    public GameObject saltShaker;
    public bool shaken = false;
    public Color colour;

    // Start is called before the first frame update
    private void Start()
    {
        XRGrabInteractable grabble = GetComponent<XRGrabInteractable>();
        saltShaker.GetComponent<ParticleSystem>().Stop(true, ParticleSystemStopBehavior.StopEmitting);
    }

    private void Update()
    {
        if (saltShaker.transform.up.y < 0)
        {
            this.gameObject.GetComponent<ParticleSystem>().Play();
        }
        else
        {
            this.gameObject.GetComponent<ParticleSystem>().Stop(true, ParticleSystemStopBehavior.StopEmitting);
        }
    }
}