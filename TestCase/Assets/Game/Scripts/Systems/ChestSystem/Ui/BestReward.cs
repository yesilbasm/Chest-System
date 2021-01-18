using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestReward : MonoBehaviour
{
    public Text Reward;

    // Start is called before the first frame update
   private void OnEnable() 
   {
       EventManager.OnChestOpened.AddListener(ChangeBestReward);
   }

   private void OnDisable() 
   {
       EventManager.OnChestOpened.RemoveListener(ChangeBestReward);
   }

    private void ChangeBestReward()
    {
        
       

            Reward.text=" " + ChestManager.Instance.Prices[2];
            
            if(ChestManager.Instance.NumberOfEpicPrices == 0 && ChestManager.Instance.NumberOfRarePrices > 0  )
            {
                Reward.text = " " + ChestManager.Instance.Prices[1];
            }

            else if(ChestManager.Instance.NumberOfEpicPrices == 0 && ChestManager.Instance.NumberOfRarePrices <= 0)
            {
                Reward.text =" " + ChestManager.Instance.Prices[0];
            }
          
    }
}
