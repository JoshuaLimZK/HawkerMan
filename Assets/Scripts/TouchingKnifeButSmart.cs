using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchingKnifeButSmart : MonoBehaviour
{
    // Start is called before the first frame update
    public int cutProgress = 0;

    public GameObject cuttableObject;
    public GameObject cutPart;
    public int numClones = 10;
    public int maximum = 9;
    public Image mask;
    public List<GingerCheckColliding> slices = new List<GingerCheckColliding>();
    public List<GarlicCheckColliding> cloves = new List<GarlicCheckColliding>();
    public GameObject chook;

    public void Start()
    {
        cutPart.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Knife")
        {
            cutProgress++;
            //Debug.Log($"cutProgress: {cutProgress}");

            float fillAmount = (float)cutProgress / (float)maximum;
            mask.fillAmount = fillAmount;

            if (cutProgress >= maximum)
            {
                cutPart.SetActive(true);

                //Debug.Log("Knife cut");

                for (int i = 0; i < numClones; i++)
                {
                    GameObject cutPartClone = Instantiate(cutPart, cuttableObject.transform.position, cuttableObject.transform.rotation);
                    cutPartClone.SetActive(true);
                    slices.Add(cutPartClone.GetComponent<GingerCheckColliding>());
                    cloves.Add(cutPartClone.GetComponent<GarlicCheckColliding>());
                    if (cutPart.name == "chicken_slices")
                    {
                        chook = cutPartClone;
                    }
                }

                cuttableObject.SetActive(false);
            }
        }
    }
}