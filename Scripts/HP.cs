using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public float stamina = 100f;

    public virtual void damageTaken(float damage, ParticleSystem particles)
    {
        stamina -= damage;
        if (stamina <= 0)
        {
            Destroy(Instantiate(particles, transform.position, Quaternion.identity), 2f);
            Destroy(this.gameObject);
        }
    }
    
    protected virtual void OnDestroy()
    {
        
    }
}
