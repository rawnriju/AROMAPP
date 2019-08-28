using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2Text : MonoBehaviour
{

    public Button b1;
    public Text b1text;


    void Start()
    {
        b1text = b1.GetComponentInChildren<Text>();
        btnValue();
    }

    public void btnValue()
    {
        b1text.text = "FEEDBACK";
    }
}
