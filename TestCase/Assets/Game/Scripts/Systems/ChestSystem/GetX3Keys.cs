using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetX3Keys : MonoBehaviour
{
    // Start is called before the first frame update
    
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
        
    }

    private void OnDisable() 
    {
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeactivateButton()
    {
        EventManager.OnGetKeys.Invoke();

    }




    

    

    
}
