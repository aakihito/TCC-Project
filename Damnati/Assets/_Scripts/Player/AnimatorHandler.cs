using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorHandler : AnimatorManager
{
    private InputHandler _inputHandler;
    private PlayerLocomotion _playerLocomotion;
    private PlayerManager _playerManager;

    private int _horizontalVelocity;
    private int _verticalVelocity;

    [SerializeField] private bool _canRotate;
    private bool _hasAnimator;

    #region  GET & SET
    public bool CanRot { get { return _canRotate; } set { _canRotate = value; }}
    public bool HasAnimator { get { return _hasAnimator; } set { _hasAnimator = value; }}
    
    #endregion

    private void Awake() 
    {
        _hasAnimator = TryGetComponent<Animator>(out Anim);

        Anim = GetComponent<Animator>(); 

        _playerLocomotion = GetComponent<PlayerLocomotion>();
        _playerManager = GetComponent<PlayerManager>();

        _horizontalVelocity = Animator.StringToHash("Horizontal");
        _verticalVelocity = Animator.StringToHash("Vertical");   
    }
    
    public void CanRotate()
    {
        _canRotate = true;
    }

    public void StopRotation()
    {
        _canRotate = false;
    }

    private void OnAnimationMove()
    {
        if(!HasAnimator)
        {
            return;
        }
        if(_playerManager.IsInteracting == false)
        {
            return;
        }

        float delta = Time.deltaTime;
        _playerLocomotion.PlayerRB.drag = 0;
        Vector3 deltaPos = Anim.deltaPosition;
        deltaPos.y = 0;
        Vector3 velocity = deltaPos / delta;
        _playerLocomotion.PlayerRB.velocity = velocity;
    }


    #region COMBAT
    public void EnableCombo()
    {
        Anim.SetBool("CanDoCombo", true);
    }

    public void DisableCombo()
    {
        Anim.SetBool("CanDoCombo", false);
    }

    public void EnableIsInvunerable()
    {
        Anim.SetBool("IsInvulnerable", true);
    }
    public void DisableIsInvunerable()
    {
        Anim.SetBool("IsInvulnerable", false);
    }

    #endregion

}
