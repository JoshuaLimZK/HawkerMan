using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfMarinated : MonoBehaviour
{
    public CheckForitems bowl;
    public bool isMarinated = false;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (bowl.done)
        {
            isMarinated = true;
        }
    }
}