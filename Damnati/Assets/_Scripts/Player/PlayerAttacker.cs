using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacker : MonoBehaviour
{
    private InputHandler _inputHandler;
    private AnimatorHandler _animator;
    private PlayerManager _playerManager;
    private PlayerInventory _playerInventory;
    private PlayerStats _playerStats;
    private string _lastAttack;
    private WeaponSlotManager _weaponSlotManager;

    public string LastAttack {get { return _lastAttack;} set { _lastAttack = value;}}
    private void Awake() 
    {
        _inputHandler = FindObjectOfType<InputHandler>();
        _playerInventory = GetComponent<PlayerInventory>();
        _animator = GetComponent<AnimatorHandler>();
        _playerManager = GetComponent<PlayerManager>();
        _playerStats = GetComponent<PlayerStats>();
        _weaponSlotManager = GetComponent<WeaponSlotManager>();
    }

    public void HandleLightAttack(WeaponItem weapon)
    {
        _weaponSlotManager.attackingWeapon = weapon;
        if(_playerManager.TwoHandFlag)
        {
            _animator.PlayTargetAnimation(weapon.TH_Light_Slash_01, true);
            LastAttack = weapon.TH_Light_Slash_01;
        }
        else
        {
            _animator.PlayTargetAnimation(weapon.SS_Light_Slash_01, true);
            _lastAttack = weapon.SS_Light_Slash_01;
        }
    }
    public void HandleHeavyAttack(WeaponItem weapon)
    {
         
        _weaponSlotManager.attackingWeapon = weapon;

        if(_playerManager.TwoHandFlag)
        {
            _animator.PlayTargetAnimation(weapon.TH_Heavy_Slash_01, true);
            _lastAttack = weapon.SS_Heavy_Slash_01;
        }
        else
        {
            _animator.PlayTargetAnimation(weapon.SS_Heavy_Slash_01, true);
            _lastAttack = weapon.SS_Heavy_Slash_01;
        }
    }

    public void HandleWeaponCombo(WeaponItem weapon)
    {
        if(_animator.Anim.GetBool("IsInteracting") == true && _animator.Anim.GetBool("CanCombo") == false)
        {
            return;
        }

        if(_inputHandler.ComboFlag)
        {
            _animator.Anim.SetBool("CanCombo", false);
            
            if(_lastAttack == weapon.SS_Light_Slash_01)
            {
                _animator.PlayTargetAnimation(weapon.SS_Light_Slash_02, true);
            }
            else if(_lastAttack == weapon.SS_Light_Slash_02)
            {
                _animator.PlayTargetAnimation(weapon.SS_Light_Slash_03, true);
            }

            else if(_lastAttack == weapon.SS_Heavy_Slash_01)
            {
                _animator.PlayTargetAnimation(weapon.SS_Heavy_Slash_02, true);
            }
            else if(_lastAttack == weapon.SS_Heavy_Slash_02)
            {
                _animator.PlayTargetAnimation(weapon.SS_Heavy_Slash_03, true);
            }

            else if(_lastAttack == weapon.TH_Light_Slash_01)
            {
                _animator.PlayTargetAnimation(weapon.TH_Light_Slash_02, true);
            }
            else if(_lastAttack == weapon.TH_Light_Slash_02)
            {
                _animator.PlayTargetAnimation(weapon.TH_Light_Slash_03, true);
            }

            else if(_lastAttack == weapon.TH_Heavy_Slash_01)
            {
                _animator.PlayTargetAnimation(weapon.TH_Heavy_Slash_02, true);
            }
            else if(_lastAttack == weapon.TH_Heavy_Slash_02)
            {
                _animator.PlayTargetAnimation(weapon.TH_Heavy_Slash_03, true);
            }
        }
    }
    
    #region Input Actions
    public void HandleLBAction()
    {
        if (_playerInventory.rightHandWeapon.isMeleeWeapon)
        {
            PerformLBMeleeAction();
        }
    }

    public void HandleRBAction()
    {
        if(_playerInventory.rightHandWeapon.isMeleeWeapon)
        {
            PerformRBMeleeAction();
        }
    }
    #endregion

    #region Attack Actions
    private void PerformLBMeleeAction()
    {
        if (_playerManager.CanDoCombo)
        {
            _inputHandler.ComboFlag = true;
            HandleWeaponCombo(_playerInventory.rightHandWeapon);
            _inputHandler.ComboFlag = false;
        }
        else
        {
            if (_playerManager.IsInteracting || _playerManager.CanDoCombo)
            {
                return;
            }

            _animator.Anim.SetBool("IsUsingRightHand", true);
            HandleLightAttack(_playerInventory.rightHandWeapon);
        }
    }

    private void PerformRBMeleeAction()
    {
        if(_playerManager.CanDoCombo)
        {
            _inputHandler.ComboFlag = true;
            HandleWeaponCombo(_playerInventory.rightHandWeapon);
            _inputHandler.ComboFlag= false;
        }
        else
        {
            if(_playerManager.IsInteracting || _playerManager.CanDoCombo)
            {
                return;
            }

            _animator.Anim.SetBool("IsUsingRightHand", true);
            HandleHeavyAttack(_playerInventory.rightHandWeapon);
        }
    } 

    #endregion
}
