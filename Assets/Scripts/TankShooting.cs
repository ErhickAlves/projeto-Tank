using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour
{
   
    public Rigidbody Bullet;
    public Transform Exit;

    public float shotSpeed = 50f;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();  
        }
    }

    void Shoot()
    {
        Rigidbody instanciaBullet;

        instanciaBullet = Instantiate(Bullet, Exit.position, Exit.rotation);

        instanciaBullet.velocity = shotSpeed * Exit.forward;
    }
}
