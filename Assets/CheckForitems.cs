using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForitems : MonoBehaviour
{
    public bool gotChicken = false;
    public bool gotGinger = false;
    public bool gotLeek = false;
    public bool gotSalt = false;
    public bool gotOil = false;
    public bool done = false;
    public CheckColliding chicken;
    public CheckColliding leekA;
    public CheckColliding leekB;
    public List<GingerCheckColliding> slices = new List<GingerCheckColliding>();
    public TouchingKnifeButSmart ginger;
    public DetectShake salt;
    public DetectShake oil;

    private int counter;

    public void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        slices = ginger.slices;
        counter = 0;
        //Debug.Log(slices);
        //Debug.Log(slices.Count);
        foreach (GingerCheckColliding slice in slices)
        {
            if (slice.isColliding)
            {
                //Debug.Log("I have checked it is colliding");
                gotGinger = true;
                counter = 0;
            }
            else
            {
                counter++;
            }
        }
        if (counter == slices.Count)
        {
            //Debug.Log("No ginger");
            gotGinger = false;
        }
        gotChicken = chicken.isCollideBowl;
        //gotGinger = ginger.isCollideBowl;
        gotLeek = leekA.isCollideBowl || leekB.isCollideBowl;
        gotSalt = salt.shaken;
        gotOil = oil.shaken;
        if (gotChicken && gotLeek && gotGinger && gotSalt && gotOil)
        {
            done = true;
        }
    }
}