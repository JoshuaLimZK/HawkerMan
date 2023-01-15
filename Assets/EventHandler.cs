using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    public CheckIfMarinated isMarinated;
    public CheckIfCooked isCooked;
    public Material marinatedMat;
    public Material defaultMat;
    public Material cookedMat;
    public GameObject chicken;
    public GameObject Menu;

    // Start is called before the first frame update
    private void Start()
    {
        chicken.GetComponent<MeshRenderer>().material = defaultMat;
    }

    // Update is called once per frame
    private void Update()
    {
        if (isCooked.cooked)
        {
            chicken.GetComponent<MeshRenderer>().material = cookedMat;
            Menu.SetActive(true);
        }
        else if (isMarinated.isMarinated)
        {
            chicken.GetComponent<MeshRenderer>().material = marinatedMat;
        }
    }
}