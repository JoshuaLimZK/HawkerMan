using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToAttach : MonoBehaviour
{
    public string colliderTag;
    public Transform attach;
    public GameObject attachee;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == colliderTag)
        {
            attachee.transform.position = attach.position;
        }
    }
}