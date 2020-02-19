using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionButton : MonoBehaviour
{
    public Animator animator;

    public void doAction()
    {
        animator.SetTrigger("attack");
    }
}
