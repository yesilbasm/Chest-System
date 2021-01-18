using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    // Start is called before the first frame update
 
    private void OnEnable() 
    {
        EventManager.OnAllKeysUsed.AddListener(()=> FindObjectOfType<Panel>().transform.GetChild(0).gameObject.SetActive(true));
    }
     private void OnDisable() 
    {
        EventManager.OnAllKeysUsed.RemoveListener(()=> FindObjectOfType<Panel>().transform.GetChild(0).gameObject.SetActive(true));
    }
    
    public void HidePanel()
    {
        gameObject.SetActive(false);
    }

    public void ShowPanel()
    {
        gameObject.SetActive(true);
    }
}

   