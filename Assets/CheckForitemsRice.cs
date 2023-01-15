using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForitemsRice : MonoBehaviour
{
    public bool gotChicken = false;
    public bool gotGinger = false;
    public bool gotLeek = false;
    public bool gotSalt = false;
    public bool gotOil = false;
    public bool gotGarlic = false;
    public bool gotPowder = false;
    public bool gotButter = false;
    public bool gotWater = false;
    public bool gotRice = false;
    public bool done = false;
    public CheckCollidingRice chicken;
    public CheckCollidingRice leekA;
    public CheckCollidingRice leekB;
    public CheckCollidingRice butter;
    public CheckCollidingRice rice;
    public List<GarlicCheckColliding> slices = new List<GarlicCheckColliding>();
    public List<GarlicCheckColliding> cloves = new List<GarlicCheckColliding>();
    public TouchingKnifeButSmart ginger;
    public TouchingKnifeButSmart garlic;
    public DetectShakeRice salt;
    public DetectShakeRice oil;
    public DetectShakeRice water;
    public DetectShakeRice powder;
    public CheckIfMarinated marinated;

    private int counter;
    private int counterA;

    public void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        slices = ginger.cloves;
        counter = 0;
        //Debug.Log(slices);
        //Debug.Log(slices.Count);
        foreach (GarlicCheckColliding slice in slices)
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
        cloves = garlic.cloves;
        counterA = 0;
        foreach (GarlicCheckColliding clove in cloves)
        {
            if (clove.isColliding)
            {
                //Debug.Log("I have checked it is colliding");
                gotGarlic = true;
                counterA = 0;
            }
            else
            {
                counterA++;
            }
        }
        if (counterA == slices.Count)
        {
            //Debug.Log("No ginger");
            gotGarlic = false;
        }
        gotChicken = chicken.isCollideBowl;
        //gotGinger = ginger.isCollideBowl;
        gotLeek = leekA.isCollideBowl || leekB.isCollideBowl;
        gotButter = butter.isCollideBowl;
        gotRice = rice.isCollideBowl;
        gotSalt = salt.shaken;
        gotOil = oil.shaken;
        gotWater = water.shaken;
        gotPowder = powder.shaken;
        if (gotGarlic && gotGinger && gotChicken && gotLeek && gotButter && gotSalt && gotOil && gotWater && gotPowder && gotRice && marinated)
        {
            done = true;
        }
    }
}