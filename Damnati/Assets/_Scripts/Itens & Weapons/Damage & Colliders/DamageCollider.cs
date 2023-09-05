using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    private CharacterManager _characterManager;
    private Collider _damageCollider;
    private bool _enabledDamageColliderOnStartUp = false;
    
    private int _currentWeaponDamage = 25;

    #region GET & SET

    public int CurrentWeaponDamage { get { return _currentWeaponDamage; } set { _currentWeaponDamage = value; }}
    public CharacterManager characterManager { get { return _characterManager; } set { _characterManager = value; }}
    public bool EnabledDamageColliderOnStartUp { get { return _enabledDamageColliderOnStartUp; } set { _enabledDamageColliderOnStartUp = value; }}

    #endregion


    private void Awake() 
    {
        _damageCollider = GetComponent<Collider>();
        _damageCollider.gameObject.SetActive(true);
        _damageCollider.isTrigger = true;
        _damageCollider.enabled = _enabledDamageColliderOnStartUp;
    }

    public void EnableDamageCollider()
    {
        _damageCollider.enabled = true;
    }
    public void DisableDamageCollider()
    {
        _damageCollider.enabled = false;
    }

    private void OnTriggerEnter(Collider collision) 
    {
        if(collision.tag == "Player")
        {
            PlayerStats playerStats = collision.GetComponent<PlayerStats>();
            CharacterManager enemyCharacterManager = collision.GetComponent<CharacterManager>();
            BlockingCollider shield = collision.transform.GetComponentInChildren<BlockingCollider>();
           
            if(enemyCharacterManager != null)
            {
                if(enemyCharacterManager.IsParrying)
                {
                    _characterManager.GetComponentInChildren<AnimatorManager>().PlayTargetAnimation("Parried", true);
                    return;  
                }
                else if(shield != null && enemyCharacterManager.IsBlocking)
                {
                    float physicalDamageAfterBlock = _currentWeaponDamage - (_currentWeaponDamage * shield.BlockingPhysicalDamageAbsorption)/ 100;

                    if(playerStats != null)
                    {
                        playerStats.TakeDamage(Mathf.RoundToInt(physicalDamageAfterBlock), "Block Idle");
                        return;
                    }
                }
            }
            if (playerStats != null)
            {
                playerStats.TakeDamage(_currentWeaponDamage);
            }
        }

        if(collision.tag == "Enemy")
        {
            EnemyStats enemyStats = collision.GetComponent<EnemyStats>();
            CharacterManager enemyCharacterManager = collision.GetComponent<CharacterManager>();
            BlockingCollider shield = collision.transform.GetComponentInChildren<BlockingCollider>();
            

            if (enemyCharacterManager != null)
            {
                if (enemyCharacterManager.IsParrying)
                {
                    _characterManager.GetComponentInChildren<AnimatorManager>().PlayTargetAnimation("Parried", true);
                    return;
                }
                else if (shield != null && enemyCharacterManager.IsBlocking)
                {
                    float physicalDamageAfterBlock =
                    _currentWeaponDamage - (_currentWeaponDamage * shield.BlockingPhysicalDamageAbsorption) / 100;

                    if (enemyStats != null)
                    {
                        enemyStats.TakeDamage(Mathf.RoundToInt(physicalDamageAfterBlock), "Block Idle");
                        return;
                    }
                }
            }

            if (enemyStats != null)
            {
                if(enemyStats.IsBoss)
                {
                    enemyStats.TakeDamageNoAnimation(_currentWeaponDamage);
                }
                else
                {
                    enemyStats.TakeDamage(_currentWeaponDamage);
                }
            }
        }        
    }
}
