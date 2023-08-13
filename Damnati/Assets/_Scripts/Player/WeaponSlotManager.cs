using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlotManager : MonoBehaviour
{
    public WeaponItem attackingWeapon;
    private WeaponHolderSlot _leftHandSlot;
    private WeaponHolderSlot _rightHandSlot;
    private WeaponHolderSlot _backSlot;

    private DamageCollider _leftHandDamageCollider;
    private DamageCollider _rightHandDamageCollider;

    private PlayerStats _playerStats;
    private PlayerManager _playerManager;
    private Animator _anim;
    
    private void Awake() 
    {   
        _playerManager = GetComponent<PlayerManager>();
        _playerStats = GetComponent<PlayerStats>();
        _anim = GetComponent<Animator>();

       WeaponHolderSlot[] weaponHolderSlots = GetComponentsInChildren<WeaponHolderSlot>();    
        
        foreach (WeaponHolderSlot weaponSlot in weaponHolderSlots)
        {
            if(weaponSlot.isLeftHandSlot)
            {
                _leftHandSlot = weaponSlot;
            }
            else if(weaponSlot.isRightHandSlot)
            {
                _rightHandSlot = weaponSlot;
            }
            else if(weaponSlot.isBackSlot)
            {
                _backSlot = weaponSlot;
            }
        }
    }

    public void LoadWeaponOnSlot(WeaponItem weaponItem, bool isLeft)
    {
        if(isLeft)
        {
           _leftHandSlot.CurrentWeapon = weaponItem;
            _leftHandSlot.LoadWeaponModel(weaponItem);
            LoadLeftWeaponDamageCollider();
            
            #region Handle Left Weapon Idle Animation 

            if(weaponItem != null)
            {
                _anim.CrossFade(weaponItem.left_Hand_Idle, 0.2f);
            }
            else
            {
                _anim.CrossFade("Left Arm Empty", 0.2f);
            }

            #endregion
        }
        else
        {
            if(_playerManager.TwoHandFlag)
            {
                _backSlot.LoadWeaponModel(_leftHandSlot.CurrentWeapon);
                _leftHandSlot.UnloadWeaponAndDestroy();
                _anim.CrossFade(weaponItem.th_idle, 0.2f);
            }
            else
            {
                #region Handle Right Weapon Idle Animation

                _anim.CrossFade("Both Arms Empty", 0.2f);
                _backSlot.UnloadWeaponAndDestroy();
                
                if(weaponItem != null)
                {
                    _anim.CrossFade(weaponItem.right_Hand_Idle, 0.2f);
                }
                else
                {
                    _anim.CrossFade("Right Arm Empty", 0.2f);
                }

                #endregion
            }
            
            _rightHandSlot.CurrentWeapon = weaponItem;
            _rightHandSlot.LoadWeaponModel(weaponItem);
            LoadRightWeaponDamageCollider();  
                 
        }
    }

    #region Handle Weapon's Damage Collider

    private void LoadLeftWeaponDamageCollider()
    {
        _leftHandDamageCollider = _leftHandSlot.currentWeaponModel.GetComponentInChildren<DamageCollider>();
    }
    private void LoadRightWeaponDamageCollider()
    {
        _rightHandDamageCollider = _rightHandSlot.currentWeaponModel.GetComponentInChildren<DamageCollider>();
    }
    public void OpenDamageCollider()
    {
        if(_playerManager.IsUsingRightHand)
        {
            _rightHandDamageCollider.EnableDamageCollider();
        }
        else if(_playerManager.IsUsingLeftHand)
        {
            _leftHandDamageCollider.EnableDamageCollider();
        }
    }

    public void CloseDamageCollider()
    {
        _rightHandDamageCollider.DisableDamageCollider();
        _leftHandDamageCollider.DisableDamageCollider();
    }

    #endregion


    #region Stamina Drain
    public void DrainsStaminaLightAttack()
    {
        _playerStats.StaminaDrain(Mathf.RoundToInt(attackingWeapon.baseStamina * attackingWeapon.lightAttackMultiplier));
    }

    public void DrainsStaminaHeavyAttack()
    {
        _playerStats.StaminaDrain(Mathf.RoundToInt(attackingWeapon.baseStamina * attackingWeapon.heavyAttackMultiplier));
    }

    #endregion
}
