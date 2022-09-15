using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliHandler : MonoBehaviour
{
    public GameObject destruParticles;
    [SerializeField] Canvas canvasGameOver;
    AudioSource audioSource;

    bool colliDisable = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        canvasGameOver.enabled = false;   
    }

    void Update()
    {
        gameMaster();
    }

    
    void gameMaster()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           gameOverUI();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            colliDisable = !colliDisable;
        }
    return;    
    }

    void OnCollisionEnter(Collision other) 
    { 
        if (colliDisable) {return;} 
        if (other.gameObject.tag == "Asteroid" )
        {
            crashSeq();
        }
    }

    void crashSeq()
    {
        Destroy(Instantiate(destruParticles, transform.position, Quaternion.identity), 5f);
        if (this.gameObject.tag == "Ship")
        {
            GetComponent<SpaceshipWeapons>().enabled = false;
            GetComponent<SpaceshipKillShot>().enabled = false;
            GetComponent<Spaceship>().enabled = false;
        }
        Destroy(this.gameObject, 0.1f);
        gameOverUI();
    }

    public void gameOverUI()
    {
        canvasGameOver.enabled = true;
        Cursor.lockState = CursorLockMode.None;   
    }
}
