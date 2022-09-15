using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : HP
{
    public ParticleSystem destruParticles;
    

    public float getForce = 10f;
    public float getTorque = 10f;
    public int numOfDeadEnemies = 0;

    Rigidbody rb;
    Score scoreBoard;
    playerScorePoints playerScore;
    

    private void Awake() 
    {
        float randSize = Random.Range(1f, 3f);
        transform.localScale = Vector3.one * randSize; 

        scoreBoard = FindObjectOfType<Score>();
        playerScore = FindObjectOfType<playerScorePoints>();
        rb = GetComponent<Rigidbody>();
        
        rb.useGravity = false;  

        rb.AddForce(Vector3.forward * getForce);
        rb.AddTorque(Vector3.forward * getTorque);  
       
    }
    public override void damageTaken(float damage, ParticleSystem particles)
    {
        int randScore =  Random.Range(1, 10);
        base.damageTaken(damage, destruParticles); 
        playerScore.IncreaseScore(randScore);
        if (base.stamina <= 0)
        {
            scoreBoard.IncreaseDeaths(numOfDeadEnemies);
        } 
    }

    

    protected override void OnDestroy()
    {
       
    }
}
