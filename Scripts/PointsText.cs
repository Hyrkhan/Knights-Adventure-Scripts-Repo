using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsText : MonoBehaviour
{

    public static PointsText instance;
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    int points;

    
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        points += coinValue;
        text.text = "POINTS :" + points.ToString();
        text2.text = "POINTS :" + points.ToString() + "/ 113";
        text3.text = "POINTS :" + points.ToString() + "/ 113";
    }
    
}
