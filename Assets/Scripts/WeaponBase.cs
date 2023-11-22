using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Flags]
public enum EAttachment
{
    extendedMag = 1,
    fasterBullets = 2,
    doubleShot= 4
}

public abstract class WeaponBase : MonoBehaviour
{
    
    
    
    [Header("Weapon Base Stats")] 
    [SerializeField] protected float timeBetweenAttacks;

    [SerializeField] protected float chargeUpTime;
    [SerializeField] [Range(0, 1)] protected float minChargePercent;
    [SerializeField] private bool isFullyAuto;


    private Coroutine _currentFireTimer;
    private bool _isOnCooldown;
    private float _currentChargeTime;

    private WaitForSeconds _coolDownWait;
    private WaitUntil _coolDownEnforce;

    [SerializeField] private float ammo;

    private float _maxAmmo;
    
    [field: SerializeField] public EAttachment Attachments { get; private set; }
    
    
    [Header("Player UI")] [SerializeField] private Image Bullets;

    private float Ammo
    {
        get => ammo;
        set
        {
            ammo = value;
            Bullets.fillAmount = ammo/_maxAmmo;
        }
    }

    private void Start()
    {
        _coolDownWait = new WaitForSeconds(timeBetweenAttacks);
        _coolDownEnforce = new WaitUntil(() => !_isOnCooldown);
        
        if (((int)Attachments & (int)EAttachment.extendedMag) == (int)EAttachment.extendedMag)
        {
            ammo = ammo * 2;
        }
        _maxAmmo = ammo;
        Ammo = _maxAmmo;
        

    }

    public void StartShooting()
    {
        _currentFireTimer = StartCoroutine(ReFireTimer());
    }

    public void StopShooing()
    {
        StopCoroutine(_currentFireTimer);

        var percent = _currentChargeTime / chargeUpTime;

        if (percent != 0) TryAttack(percent);
    }

    private IEnumerator CooldownTimer()
    {
        _isOnCooldown = true;

        yield return _coolDownWait;

        _isOnCooldown = false;
    }


    private IEnumerator ReFireTimer()
    {
        yield return _coolDownEnforce;

        while (_currentChargeTime < chargeUpTime)
        {
            _currentChargeTime += Time.deltaTime;
            yield return null;
        }

        TryAttack(1);
        yield return null;
    }

    private void TryAttack(float percent)
    {
        if (ammo > 0)
        {
            _currentChargeTime = 0;
            if (!CanAttack(percent)) return;

            Attack(percent);

            StartCoroutine(CooldownTimer());

            if (isFullyAuto && percent >= 1) _currentFireTimer = StartCoroutine(ReFireTimer());

            Ammo--;
        }
    }

    protected virtual bool CanAttack(float percent)
    {
        return !_isOnCooldown && percent >= minChargePercent;
    }

    public void Reload()
    {
        //makes ammo go back to full 
        Ammo = _maxAmmo;
    }

    protected abstract void Attack(float percent);
}