using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfCooked : MonoBehaviour
{
    public CheckForitemsRice rice;
    public bool cooked = false;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (rice.done)
        {
            cooked = true;
        }
    }
}