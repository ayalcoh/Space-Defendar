using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class ZeroGMovement : MonoBehaviour
{
    [Header("=== Player Movement Settings ===")]
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

    private Camera mainC;
    [SerializeField] 
    private CinemachineVirtualCamera playerCamera;
    private Animator animate;
    

    
    
    


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
    public bool walking ;
    public float currentBoostAmount;

    Rigidbody rb;
    private float thrust1D;
    private float upDown1D;
    private float strafe1D;
    private float roll1D;
    private Vector2 pitchYaw;

    public Spaceship ShipToEnter;

    public delegate void OnRequestShipEntry();
    public event OnRequestShipEntry onRequestShipEntry;


    // Start is called before the first frame update
    void Start()
    {
        mainC = Camera.main;
        rb = GetComponent<Rigidbody>();
        animate = GetComponent<Animator>();
        rb.useGravity = false;
        currentBoostAmount = maxBoostAmount;
        ShipToEnter = null;
        SwitchCinemaScene.switchCamera(playerCamera);
    }

    private void OnEnable() 
    {
        if (playerCamera != null) {SwitchCinemaScene.Register(playerCamera);}
        
    }

    private void OnDisable() 
    {
        if (playerCamera != null) {SwitchCinemaScene.UnRegister(playerCamera);}
        
    }

    void FixedUpdate() 
    {
       
        boostingTrans();
        movementTrans();
    }

   
    void EnteringShip()
    {
        transform.parent = ShipToEnter.transform;
        this.gameObject.SetActive(false);

        if (onRequestShipEntry != null) onRequestShipEntry();
    }

    void ExitingShip()
    {
        transform.parent = null;
        this.gameObject.SetActive(true);
        SwitchCinemaScene.switchCamera(playerCamera);
    }

    public void getShip(Spaceship ship)
    {
        ShipToEnter = ship;
        if (ShipToEnter != null) {ShipToEnter.onRequestShipExit += ExitingShip;}
    }

    public void removeShip()
    {
        ShipToEnter.onRequestShipExit -= ExitingShip;
        ShipToEnter = null;
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
        rb.AddTorque(-mainC.transform.forward * roll1D * roll * Time.deltaTime);
        //pitch
        rb.AddRelativeTorque(Vector3.right * Mathf.Clamp(-pitchYaw.y, -1f,1f) * pitch * Time.deltaTime);
        // //yaw
        rb.AddRelativeTorque(Vector3.up * Mathf.Clamp(pitchYaw.x, -1f,1f) * yaw * Time.deltaTime);
       
        //thrust
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

            rb.AddForce(mainC.transform.forward * thrust1D * currentThrust * Time.deltaTime);
            glide = thrust;
        }
        else
        {
            
            rb.AddForce(mainC.transform.forward * glide * Time.deltaTime);
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
            rb.AddForce(mainC.transform.right * strafe1D * upThrust * Time.fixedDeltaTime);
            horiGlide = strafe1D * strafeThrust;
        }
        else
        {
            rb.AddForce(mainC.transform.right * horiGlide * Time.fixedDeltaTime);
            horiGlide *= leftRightGlideReduction;
        }



    }

    #region Input Methods
    public void OnThrust(InputAction.CallbackContext context)
    {
        thrust1D = context.ReadValue<float>();
        if (thrust1D > 0)   
        {
            animate.SetBool("walk", true);
        } 
        else 
        {
            animate.SetBool("walk", false);
        }
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

    public void OnInteraction(InputAction.CallbackContext context)
    {
        if (ShipToEnter != null && context.action.triggered)
        {
            EnteringShip();
        }
        
    }

    public void OnPitchYaw(InputAction.CallbackContext context)
    {
        pitchYaw = context.ReadValue<Vector2>();   
        
    }

    public void onBoost(InputAction.CallbackContext context)
    {
        boosting = context.performed;
    }
    #endregion
}
