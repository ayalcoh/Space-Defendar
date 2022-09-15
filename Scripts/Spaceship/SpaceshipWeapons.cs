using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceshipWeapons : MonoBehaviour
{
    [Header("===== Settings ====")]
    [SerializeField] private Spaceship spaceship;

    [Header("===== Settings ====")]
    [SerializeField]
    private Transform[] weaponSettings;
    [SerializeField]
    private Transform posMiddle;
    [SerializeField]
    private LayerMask shootableMask;
    [SerializeField]
    private float weaponRange;
   
    
    

    [Header("===== Laser Settings ====")]
    [SerializeField]
    private LineRenderer[] lasers;
    [SerializeField]
    private ParticleSystem laserHitParticles;
    [SerializeField]
    private float LaserDamage = 1f;
    [SerializeField]
    private float damageTakenBeetwinHits = 0.25f;//not every frame just every 0.25 seconds
    private float currTimeBeetwinHits;
    [SerializeField]
    private float laserHeatThreshold = 2f;
    [SerializeField]
    private float laserHeattRate = 0.25f;
    [SerializeField]
    private float laserCoolRate = 0.5f;

    private float currLaserHeat = 0f;
    private bool laserHeated = false;

    private bool combat;
    private Camera cam;


    private void Awake() 
    {
        cam = Camera.main;
        spaceship = GetComponent<Spaceship>();
        
    }

    private void Update() 
    {
        if (spaceship.IsTaken)
        {
            handleFiring();
        }

           
    }

    public float CurrentLaserHeat
    {
        get { return currLaserHeat;}
    }

     public float LaserHeatThreshold
    {
        get { return laserHeatThreshold;}
    }


    private void handleFiring()
    {
        if (combat && !laserHeated)
        {
            fireLaser();
        }
        else
        {
            foreach(var laser in lasers)
            {
                laser.gameObject.SetActive(false);
            }
            coolLaser();
        }
    }

    void fireLaser()
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

        heatLaser();
    }

    void heatLaser()
    {
        if (combat && currLaserHeat < laserHeatThreshold)
        {
            currLaserHeat += laserHeattRate * Time.deltaTime;
            if (currLaserHeat >= laserHeatThreshold)
            {
                laserHeated = true;
                combat = false;
            }   
        }
    }

    void coolLaser()
    {
        if (laserHeated)
        {
            if (currLaserHeat / laserHeatThreshold <= 0.5f) // can fire again at 50% of threshold
            {
                laserHeated = false;
            }
        }
        if (currLaserHeat > 0f)
        {
            currLaserHeat -= laserCoolRate * Time.deltaTime;
        }      
    }

    void damageOnTar(HP stamina)
    {
        currTimeBeetwinHits += Time.deltaTime;
        if ( currTimeBeetwinHits > damageTakenBeetwinHits)
        {
            stamina.damageTaken(LaserDamage, laserHitParticles);
            currTimeBeetwinHits = 0;
        }
    }

    #region Input
    public void inCombat(InputAction.CallbackContext context)
    {
        combat = context.performed;
    }
    #endregion




}
