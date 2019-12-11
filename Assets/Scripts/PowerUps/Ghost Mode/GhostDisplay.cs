using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostDisplay : MonoBehaviour
{
    public GhostData g;
    public Text ghostText;

    GhostMode ghostModeScript;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the text component
        ghostText = GetComponent<Text>();

        ghostModeScript = GameObject.FindWithTag("Player").GetComponent<GhostMode>();
    }

    // Update is called once per frame
    void Update()
    {
        //Checks to see if the player has gotten the powerup
        if (g.GetCount() == 1)
        {
            ghostText.text = " ";
        }
        else
        {
            if (ghostModeScript.ghostModeStart > 4)
            {
                ghostText.text = "Ghost   X";
            }
            else
            {
                ghostText.text = "Ghost";
            }
        }
    }
}
