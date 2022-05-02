using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManger : SingeltonGeneric<AnimationManger>
{
    #region singelton
    private void Awake()
    {
        MakeSingelton(this);
    }
    #endregion
    [SerializeField] Animator PlayerAnimator;
    public void RunAnimation()
    {
        PlayerAnimator.SetBool("RunAnimation", true);
    }
    public void IdleAnimation()
    {
        PlayerAnimator.SetBool("RunAnimation", false);
    }
}
