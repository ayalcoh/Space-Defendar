using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image laserHeatBar;
    [SerializeField] private Image boostHeatBar;

    [SerializeField] private SpaceshipWeapons spaceshipShootBar;
    [SerializeField] private Spaceship spaceshipBoostBar;

    private void Start() 
    {
        spaceshipShootBar = FindObjectOfType<SpaceshipWeapons>();
        spaceshipBoostBar = FindObjectOfType<Spaceship>();    
    }
    private void Update() 
    {
        if (spaceshipShootBar != null)
        {
            laserHeatBar.fillAmount = spaceshipShootBar.CurrentLaserHeat / spaceshipShootBar.LaserHeatThreshold;
        }
        if (spaceshipBoostBar != null)
        {
            boostHeatBar.fillAmount = spaceshipBoostBar.CurrentBoostAmount / spaceshipBoostBar.MaxBoostAmount;
        }                
    }
}
