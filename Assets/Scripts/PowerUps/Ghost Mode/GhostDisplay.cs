using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostDisplay : MonoBehaviour
{
    public GhostData g;
    public Text ghostText;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the text component
        ghostText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Checks to see if the player has gotten the powerup
        if (g.GetCount() == 0)
        {
            ghostText.text = "Ghost";
        }
        else
        {
            ghostText.text = " ";
        }
    }
}
