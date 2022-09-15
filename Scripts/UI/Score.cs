using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int numOfHits = 0;
    public TMP_Text deaths;

    [SerializeField] Canvas canvasGameOver;

    public void Start()
    {    
        deaths = GetComponent<TMP_Text>();
        canvasGameOver.enabled = false;  
        deaths.text = "";
    }

   
    public void IncreaseDeaths(int numToIncrease)
    {
        numOfHits += numToIncrease;
        deaths.text = string.Format(numOfHits + "/10");
         
        if (numOfHits == 10)
        {
            gameOverUI();
        }    
    }

    public void gameOverUI()
    {
        canvasGameOver.enabled = true;
        Cursor.lockState = CursorLockMode.None;   
    } 

    
}
