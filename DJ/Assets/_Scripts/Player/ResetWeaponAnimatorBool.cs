using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetWeaponAnimatorBool : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        string attackBool = "attack";
        bool attackBoolValue = false;

        animator.SetBool(attackBool, attackBoolValue);
    }

}
