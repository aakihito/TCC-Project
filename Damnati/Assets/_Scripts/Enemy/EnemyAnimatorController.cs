using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimatorController : AnimatorManager
{
    private EnemyManager _enemyManager;
    private EnemyStats _enemyStats;
    private void Awake() 
    {
        Anim = GetComponent<Animator>();
        _enemyStats = GetComponent<EnemyStats>();
        _enemyManager = GetComponent<EnemyManager>();    
    }

    private void OnAnimatorMove()
    {
        float delta = Time.deltaTime;
        _enemyManager.EnemyRb.drag = 0;
        Vector3 deltaPosition = Anim.deltaPosition;
        deltaPosition.y = 0;
        Vector3 velocity = deltaPosition / delta;
        _enemyManager.EnemyRb.velocity = velocity;
    }

    public override void TakeCriticalDamageAnimationEvent()
    {
        _enemyStats.TakeDamageNoAnimation(_enemyManager.PendingCriticalDamage);
        _enemyManager.PendingCriticalDamage = 0;
    } 
}
