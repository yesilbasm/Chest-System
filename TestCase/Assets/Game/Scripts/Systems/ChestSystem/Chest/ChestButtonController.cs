using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestButtonController : MonoBehaviour
{
    

    
    
    private Button button;
    private Button Button
    {
        get
        {

        
            if(button == null)
            {
                button = GetComponent<Button>();
            }
            return button;
        }
    }

    private void OnEnable() 
    {
        EventManager.OnAllKeysUsed.AddListener(DisableButtons);
        EventManager.OnGetKeys.AddListener(EnableButtons);        
    }

    private void OnDisable() 
    {
        EventManager.OnAllKeysUsed.RemoveListener(DisableButtons);
        EventManager.OnGetKeys.RemoveListener(EnableButtons); 
    }

    public void DisableButtons()
    {
        Button.enabled = false;
    }

    public void EnableButtons()
    {
        ChestManager.Instance.AvaliableKeys =3;
        Button.enabled = true;

    }

}
