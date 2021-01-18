using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    private Animator animator;
    public Animator Animator { get { return (animator == null) ? animator = GetComponent<Animator>() : animator; } }
    private void OnEnable() 
    {
         
        EventManager.OnAllKeysUsed.AddListener(()=> FindObjectOfType<Panel>().transform.GetChild(0).gameObject.SetActive(true));   
        EventManager.OnKeyUsed.AddListener(DeactivateKeys);
        EventManager.OnGetKeys.AddListener(()=> Animator.SetTrigger("GetX3Keys"));
    }

    private void OnDisable() 
    {
        
        EventManager.OnAllKeysUsed.RemoveListener(()=> FindObjectOfType<Panel>().transform.GetChild(0).gameObject.SetActive(true)); 
        EventManager.OnKeyUsed.RemoveListener(DeactivateKeys);
        EventManager.OnGetKeys.RemoveListener(()=> Animator.SetTrigger("GetX3Keys"));
    }

    public void DeactivateKeys()
    {
        string value = "Key" + ChestManager.Instance.AvaliableKeys.ToString()+"Used";
        Animator.SetTrigger(value);
        Debug.Log(value);
        
        

    }

}
