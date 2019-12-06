using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureDisplay : MonoBehaviour
{
    public TreasureData t;
    public Text treasureText;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the text component
        treasureText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Checks to see if the player has gotten all the treasures
        if (t.GetCount() == 0)
        {
            treasureText.text = "You win!";
        }
        else
        {
            treasureText.text = "Treasures Left: " + t.GetCount().ToString();
        }
    }
}
