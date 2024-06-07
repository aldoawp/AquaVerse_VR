using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBullet : MonoBehaviour
{
     public float damage = 10f;

    void OnCollisionEnter(Collision collision)
    {
        HealthConfiguration target = collision.gameObject.GetComponent<HealthConfiguration>();
        if (target != null)
        {
            target.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

}
