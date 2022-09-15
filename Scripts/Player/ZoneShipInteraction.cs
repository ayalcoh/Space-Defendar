using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneShipInteraction : MonoBehaviour
{
    [SerializeField] private Spaceship spaceship;

    private ZeroGMovement player;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject.GetComponentInParent<ZeroGMovement>();
            if (player != null) player.getShip(spaceship);
            
        }      
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (player != null) player.removeShip();
            
        }      
    }

}
