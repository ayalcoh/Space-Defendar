using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class playerScorePoints : MonoBehaviour
{
    public int hitPoints = 0;
    public TMP_Text hitScore;
    

    void Start()
    {    
        hitScore = GetComponent<TMP_Text>();
        hitScore.text = "";
    }

   
    public void IncreaseScore(int numToIncrease)
    {
        hitPoints += numToIncrease;
        hitScore.text = hitPoints.ToString();  
    }
}
