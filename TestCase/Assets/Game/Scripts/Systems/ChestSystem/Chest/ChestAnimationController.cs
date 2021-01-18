using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimationController : MonoBehaviour
{
    
    
    private Animator animator;
    public Animator Animator { get { return (animator == null) ? animator = GetComponent<Animator>() : animator; } }


    private void OnEnable() 
    {
        
        EventManager.OnGetKeys.AddListener(()=> InvokeTrigger("GetX3Keys"));    
    }

    private void OnDisable() 
    {
         
        EventManager.OnGetKeys.RemoveListener(()=> InvokeTrigger("GetX3Keys"));
    }

    public void OpenChests()
    {
        InvokeTrigger("Click");
    }


    public void UseKeys()
    {
        Animator.SetTrigger("ChestOpened");
        
    }    
    private void InvokeTrigger(string value)
    {
        Animator.SetTrigger(value);
    }

   




}
