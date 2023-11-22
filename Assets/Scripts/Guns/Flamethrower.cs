using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flameThrower : WeaponBase
{
    [SerializeField] private Rigidbody myBullet;
    
    [SerializeField] public float force = 100;

    public int amountOfBullets;

    public float spread;

    protected override void Attack(float percent)
    {
        if (((int)Attachments & (int)EAttachment.fasterBullets) == (int)EAttachment.fasterBullets)
        {
            force = 300;
        }
        
        for (int i = 0; i < amountOfBullets; i++)
        {
            if (((int)Attachments & (int)EAttachment.doubleShot) == (int)EAttachment.doubleShot)
            {
                Ray camRay1 = InputManager.GetCameraRay();
            
                Rigidbody rb1 = Instantiate(myBullet, camRay1.origin, transform.rotation);
            
                rb1.AddForce(camRay1.direction * force, ForceMode.Impulse);
            }
            
            Ray camRay = InputManager.GetCameraRay();
            
            Rigidbody rb = Instantiate(myBullet, camRay.origin, transform.rotation);
            
            rb.AddForce(camRay.direction * force, ForceMode.Impulse);
        }
    }
    
}