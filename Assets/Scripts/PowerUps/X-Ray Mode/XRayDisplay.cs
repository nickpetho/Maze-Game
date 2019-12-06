using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XRayDisplay : MonoBehaviour
{
    public XRayData x;
    public Text xrayText;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the text component
        xrayText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Checks to see if the player has gotten the powerup
        if (x.GetCount() == 0)
        {
            xrayText.text = "X-Ray";
        }
        else
        {
            xrayText.text = " ";
        }
    }
}
