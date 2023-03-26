using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectile;
    public AudioSource audioSource;
    public float fireRate = 2F;
    public float nextFire = 0.0F;
    public int bullets = 5;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            
            nextFire = Time.time + fireRate;
            Destroy(projectile);
            audioSource.Play();
            bullets--;
        }
        
    }
}


