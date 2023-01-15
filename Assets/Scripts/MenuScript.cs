using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public Transform mainObject;
    public GameObject menu;
    public Transform head;
    public float offest = 0.1F;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        menu.transform.position = mainObject.position + new Vector3(0, 1, 0).normalized * offest;
        menu.transform.LookAt(new Vector3(head.position.x, head.position.y, head.position.z));
    }
}