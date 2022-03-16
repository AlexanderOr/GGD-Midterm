using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour
{
    public Text goldText;
    private int gold;

    private void Start()
    {
    
        gold = 200;
    
    }

    public int Gold
    {
        
        get
        {
            return gold;
        }
        set
        {
            gold = value;
            goldText.GetComponent<Text>().text = "GOLD: " + gold;

        }

    }
}