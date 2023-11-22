using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private WeaponBase myWeapon;
    [SerializeField] private WeaponBase myWeapon2;
    [SerializeField] private WeaponBase myWeapon3;
    [SerializeField] private WeaponBase myWeapon4;
    private bool weaponShootToggle;

    private WeaponBase weaponInUse;
    
    public void Weapon1()
    {
        weaponInUse = myWeapon;
        
    }    
    public void Weapon2()
    {
        weaponInUse = myWeapon2;
    }

    public void Weapon3()
    {
        weaponInUse = myWeapon3;
    }

    public void Weapon4()
    {
        weaponInUse = myWeapon4;
    }
    
    private void Start()
    {
        InputManager.Init(this);
        InputManager.EnableInGame();
        
        weaponInUse = myWeapon;

    }

    public void Shoot()
    {
        weaponShootToggle = !weaponShootToggle;
        
            if (weaponShootToggle) weaponInUse.StartShooting();
            
            else weaponInUse.StopShooing();
    }

    public void Reload()
    {
        weaponInUse.Reload();
    }
    
}
