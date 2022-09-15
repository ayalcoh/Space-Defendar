using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

[RequireComponent (typeof(Rigidbody))]
public class Spaceship : MonoBehaviour
{
    [Header("=== Ship Movement Settings ===")]
    [SerializeField]
    private float yaw = 500f;
    [SerializeField]
    private float pitch = 1000f;
    [SerializeField]
    private float roll = 100f;
    [SerializeField]
    private float thrust = 100f;
    [SerializeField]
    private float upThrust = 50f;
    [SerializeField]
    private float strafeThrust = 50f;
    [SerializeField, Range(0.001f, 0.999f)]
    private float thrustGlideReduction = 0.111f;
    [SerializeField, Range(0.001f, 0.999f)]
    private float upDownGlideReduction = 0.111f;

    [SerializeField, Range(0.001f, 0.999f)]
    private float leftRightGlideReduction = 0.111f;
    private float glide, verticalGlide, horiGlide = 0f;

    [Header("=== Boost Settings ===")]
    [SerializeField]
    private float maxBoostAmount = 20f; // how much power for boost 
    [SerializeField]
    private float boostDecreaseRate = 0.25f; // how quickly the tank decrease while pressing the boost
    [SerializeField]
    private float boostRechargeRate = 0.5f; //how quickly refills when not pressing
    [SerializeField]
    private float boostMultiplier = 5f; // how fast actully make the player go
    public bool boosting = false;
    public float currentBoostAmount;

    [SerializeField] private CinemachineVirtualCamera shipFirstPersonCam;
    [SerializeField] private CinemachineVirtualCamera shipThirdPersonCam;

    Rigidbody rb;
    private float thrust1D;
    private float upDown1D;
    private float strafe1D;
    private float roll1D;
    private Vector2 pitchYaw;

    private bool isTaken = false;

    public bool IsTaken { get { return isTaken; } }


    private ZeroGMovement player;

    public delegate void OnRequestShipExit();
    public event OnRequestShipExit onRequestShipExit;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentBoostAmount = maxBoostAmount;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<ZeroGMovement>();
        player.onRequestShipEntry += playerInShip;
    }

    private void OnEnable() 
    {
        if (shipFirstPersonCam != null) {SwitchCinemaScene.Register(shipFirstPersonCam);}
    }

    private void OnDisable() 
    {
        if (shipFirstPersonCam != null) {SwitchCinemaScene.UnRegister(shipFirstPersonCam);}
        
    }

    void FixedUpdate() 
    {
        if (isTaken)
        {
            boostingTrans();
            movementTrans();
        }
        
    }

    public float CurrentBoostAmount
    {
        get { return currentBoostAmount;}
    }

     public float MaxBoostAmount
    {
        get { return maxBoostAmount;}
    }
    void boostingTrans()
    {
        if ( boosting && currentBoostAmount > 0f)
        {
            currentBoostAmount -= boostDecreaseRate;
            if (currentBoostAmount <= 0f)
            {
                boosting = false;
            }
        }
        else
        {
            if (currentBoostAmount < maxBoostAmount)
            {
                currentBoostAmount += boostRechargeRate;
            }
        }        
    }

    void movementTrans()
    {
        // Roll
        rb.AddRelativeTorque(Vector3.back * roll1D * roll * Time.deltaTime);
        //pitch
        rb.AddRelativeTorque(Vector3.right * Mathf.Clamp(-pitchYaw.y, -1f,1f) * pitch * Time.deltaTime);
        //yaw
        rb.AddRelativeTorque(Vector3.up * Mathf.Clamp(pitchYaw.x, -1f,1f) * yaw * Time.deltaTime);
       
        if (thrust1D > 0.1f || thrust1D < -0.1f) // for controller
        {
            float currentThrust;

            if (boosting)
            {
                currentThrust = thrust * boostMultiplier;
            }
            else{
                currentThrust = thrust;
            }

            rb.AddRelativeForce(Vector3.forward * thrust1D * currentThrust * Time.deltaTime);
            glide = thrust;
        }
        else
        {
            rb.AddRelativeForce(Vector3.forward * glide * Time.deltaTime);
            glide *= thrustGlideReduction;
        }

        //DOWN//UP
         if (upDown1D > 0.1f || upDown1D < -0.1f) // for controller
        {;
            rb.AddRelativeForce(Vector3.up * upDown1D * upThrust * Time.fixedDeltaTime);
            verticalGlide = upDown1D * upThrust;
        }
        else
        {
            rb.AddRelativeForce(Vector3.up * verticalGlide * Time.fixedDeltaTime);
            verticalGlide *= upDownGlideReduction;
        }
        //Strafing
         if (strafe1D > 0.1f || strafe1D < -0.1f) // for controller
        {;
            rb.AddRelativeForce(Vector3.right * strafe1D * upThrust * Time.fixedDeltaTime);
            horiGlide = strafe1D * strafeThrust;
        }
        else
        {
            rb.AddRelativeForce(Vector3.right * horiGlide * Time.fixedDeltaTime);
            horiGlide *= leftRightGlideReduction;
        }



    }

     void playerInShip()
    {
        rb.isKinematic = false;
        SwitchCinemaScene.switchCamera(shipFirstPersonCam);
        isTaken = true;
      
    }

    void playerExitedShip()
    {
        rb.isKinematic = true;
        isTaken = false;
        if (onRequestShipExit != null) onRequestShipExit();
    }

    #region Input Methods
    public void OnThrust(InputAction.CallbackContext context)
    {
        thrust1D = context.ReadValue<float>();
    }

    public void OnStrafe(InputAction.CallbackContext context)
    {
        strafe1D = context.ReadValue<float>();
    }

    public void OnUpDown(InputAction.CallbackContext context)
    {
        upDown1D = context.ReadValue<float>();
    }

    public void OnRoll(InputAction.CallbackContext context)
    {
        roll1D = context.ReadValue<float>();        
    }

    public void OnPitchYaw(InputAction.CallbackContext context)
    {
        pitchYaw = context.ReadValue<Vector2>();        
    }

    public void onBoost(InputAction.CallbackContext context)
    {
        boosting = context.performed;
    }

    public void OnInteraction(InputAction.CallbackContext context)
    {
        if (isTaken && context.action.triggered)
        {
            playerExitedShip();
        }
    }    
    public void OnSwitchCamera(InputAction.CallbackContext context)
    {
        if (isTaken && context.action.triggered)
        {
            if (SwitchCinemaScene.isActiveCamera(shipFirstPersonCam))
            {
                SwitchCinemaScene.switchCamera(shipThirdPersonCam);
            }
            else if (SwitchCinemaScene.isActiveCamera(shipThirdPersonCam))
            {
                SwitchCinemaScene.switchCamera(shipFirstPersonCam);   
            }
        }

    }
    #endregion

   



}
