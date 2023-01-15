using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionIfDone : MonoBehaviour
{
    public CheckIfComplete checking;
    public Transform platePos;
    public GameObject goodChicken;
    public GameObject plate;
    public GameObject rice;
    public GameObject cucumberA;
    public GameObject cucumberB;
    public GameObject chicken;
    public TouchingKnifeButSmart penis;

    // Start is called before the first frame update
    private void Start()
    {
        goodChicken.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (checking.done)
        {
            Destroy(penis.chook);
            goodChicken.SetActive(true);
            goodChicken.transform.position = plate.transform.position;
            plate.SetActive(false);
            rice.SetActive(false);
            cucumberB.SetActive(false);
            cucumberA.SetActive(false);
            chicken.SetActive(false);
        }
    }
}