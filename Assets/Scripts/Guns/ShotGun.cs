using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShotGun : WeaponBase
{
    [SerializeField] private Rigidbody myBullet;
    
    [SerializeField] public float force = 50;

    public int amountOfBullets;

    public float spread;


    
    protected override void Attack(float percent)
    {

        if (((int)Attachments & (int)EAttachment.fasterBullets) == (int)EAttachment.fasterBullets)
        {
            force = 150;
        }


        for (int i = 0; i < amountOfBullets; i++)
        {
            if (((int)Attachments & (int)EAttachment.doubleShot) == (int)EAttachment.doubleShot)
            {
                Ray camRay1 = InputManager.GetCameraRay();
            
                float angle1 = spread * amountOfBullets;
                Quaternion rotation1 = Quaternion.AngleAxis(angle1, camRay1.origin);
            
                Rigidbody rb1 = Instantiate(myBullet, camRay1.origin, rotation1);
            
                rb1.AddForce(camRay1.direction * force, ForceMode.Impulse);
            }
            
            Ray camRay = InputManager.GetCameraRay();
            
            float angle = spread * amountOfBullets;
            Quaternion rotation = Quaternion.AngleAxis(angle, camRay.origin);
            
            Rigidbody rb = Instantiate(myBullet, camRay.origin, rotation);
            
            rb.AddForce(camRay.direction * force, ForceMode.Impulse);
        }
    }



    
}