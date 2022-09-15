using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHP : HP
{
    public ParticleSystem destruParticles;
    public override void damageTaken(float damage, ParticleSystem particles)
    {
        base.damageTaken(damage, destruParticles);    
    }

    protected override void OnDestroy()
    {
        
    }
}
