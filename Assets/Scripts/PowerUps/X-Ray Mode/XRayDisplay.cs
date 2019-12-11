using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XRayDisplay : MonoBehaviour
{
    public XRayData x;
    public Text xrayText;

    XRayMode xrayModeScript;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the text component
        xrayText = GetComponent<Text>();

        xrayModeScript = GameObject.FindWithTag("Player").GetComponent<XRayMode>();
    }

    // Update is called once per frame
    void Update()
    {
        //Checks to see if the player has gotten the powerup
        if (x.GetCount() == 1)
        {
            xrayText.text = " ";
        }
        else
        {
            if (xrayModeScript.xRayModeStart > 7)
            {
                xrayText.text = "X-Ray   X";
            }
            else
            {
                xrayText.text = "X-Ray";
            }
        }
    }
}
