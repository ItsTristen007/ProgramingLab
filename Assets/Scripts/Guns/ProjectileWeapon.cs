using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeapon : WeaponBase
{
    [SerializeField] private Rigidbody myBullet;

    [SerializeField] private Rigidbody myBullet2;
    
    [SerializeField] public float force = 50;

    
    protected override void Attack(float percent)
    {
        if (((int)Attachments & (int)EAttachment.fasterBullets) == (int)EAttachment.fasterBullets)
        {
            force = 150;
        }

        if (((int)Attachments & (int)EAttachment.doubleShot) == (int)EAttachment.doubleShot)
        {
            Ray camRay1 = InputManager.GetCameraRay();
            Rigidbody rb1 = Instantiate(percent>0.5f?myBullet2:myBullet, camRay1.origin, transform.rotation);
            rb1.AddForce(camRay1.direction * force, ForceMode.Impulse);
        }
        
        Ray camRay = InputManager.GetCameraRay();
        Rigidbody rb = Instantiate(percent>0.5f?myBullet2:myBullet, camRay.origin, transform.rotation);
        rb.AddForce(camRay.direction * force, ForceMode.Impulse);

    }
    
    
    
    
}