using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceshipKillShot : MonoBehaviour
{
    [Header("===== Settings ====")]
    [SerializeField] private Spaceship spaceship;

    [Header("===== Settings ====")]
    [SerializeField]
    private Transform posMiddle;
    [SerializeField]
    private LayerMask shootableMask;
    [SerializeField]
    private float weaponRange;
    
    

    [Header("===== Kill Shot Settings ====")]
    [SerializeField]
    private LineRenderer[] lasers;
    [SerializeField]
    private ParticleSystem laserHitParticles;
    [SerializeField]
    private float LaserDamage = 50f;
    private bool rocketCombat;
    private Camera cam;
    Score scoreBoard;
    


    private void Awake() 
    {
        cam = Camera.main;
        spaceship = GetComponent<Spaceship>();
        scoreBoard = FindObjectOfType<Score>();
        
    }

    private void Update() 
    {
        if (spaceship.IsTaken)
        {
            handleFiring();
        }
        else
        {
            foreach(var laser in lasers)
            {
                laser.gameObject.SetActive(false);
            }   
        }      
    }

    private void handleFiring()
    {
        if (rocketCombat)
        {
            fireMissile();
        }
        else
        {
            foreach(var laser in lasers)
            {
                laser.gameObject.SetActive(false);
            }
            
        }
    }


     void fireMissile()
    {
        RaycastHit getHitInfo;
        if(getTargetInfo.getTargetRange(posMiddle.transform.position, posMiddle.transform.forward, out getHitInfo, weaponRange, shootableMask))     
        {
            if (getHitInfo.collider.GetComponentInParent<HP>()) damageOnTar(getHitInfo.collider.GetComponentInParent<HP>());
            Instantiate(laserHitParticles, getHitInfo.point, Quaternion.LookRotation(getHitInfo.normal));

            foreach(var laser in lasers)
            {
                //convert hitted target point position to our laser localPos
                Vector3 localHitPosition = laser.transform.InverseTransformPoint(getHitInfo.point);
                laser.gameObject.SetActive(true);
                laser.SetPosition(1, localHitPosition); // form a line from player to hitted target
            }
        }
        else
        {//if we dont hit just fire to the distance
            foreach(var laser in lasers)
            {
                laser.gameObject.SetActive(true);
                laser.SetPosition(1, new Vector3(0, 0, weaponRange));  
            }
        }
    }


    void damageOnTar(HP stamina)
    {
        stamina.damageTaken(LaserDamage, laserHitParticles);
    }
     #region Input
    public void RocketLunch(InputAction.CallbackContext context)
    {
        rocketCombat = context.performed;
    }
    #endregion
}
