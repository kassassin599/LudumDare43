using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour {

    Text message;

    private void Start()
    {
        message = GetComponent<Text>();
    }

    void Update () {
        if (Score.scoreValue == 1)
        {
            message.text = "Meet Blue..";
        }
        if (Score.scoreValue == 5)
        {
            message.text = "Careful, He's killing us.";
        }
        if (Score.scoreValue == 10)
        {
            message.text = "WHAT'S HAPPNING??";
        }
        if (Score.scoreValue == 15)
        {
            message.text = "We can't kill him.";
        }

    }
}
