using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestController : MonoBehaviour
{
   

  
    public Text CoinText;

    public Text BgText;

    private List<int> Regards;

    private void Start() {
        Regards = ChestManager.Instance.Prices;
    }

    public void  DetectChestPrice()
    {
        
        
        EventManager.OnKeyUsed.Invoke();
        ChestManager.Instance.AvaliableKeys --;


        int Percentage = Random.Range(ChestManager.Instance.RangeSmaller , ChestManager.Instance.RangeBigger);

        if(Percentage > 95) 
        {
            ChestManager.Instance.PriceIndex = 2;
            ChestManager.Instance.NumberOfEpicPrices --;
            
            if(ChestManager.Instance.NumberOfEpicPrices == 0)
            {
                
                ChestManager.Instance.RangeBigger = 95;
                
                
            }

            
        }

        else if(Percentage > 75 )
        {
            ChestManager.Instance.PriceIndex = 1;

            ChestManager.Instance.NumberOfRarePrices--;
            
            
            
            if(ChestManager.Instance.NumberOfRarePrices == 0 && ChestManager.Instance.NumberOfCommonPrices== 0)
            { 
                ChestManager.Instance.RangeSmaller = 95;
            }

            if(ChestManager.Instance.NumberOfRarePrices<0 && ChestManager.Instance.NumberOfCommonPrices>0)
            {
                ChestManager.Instance.PriceIndex = 0;
                ChestManager.Instance.NumberOfRarePrices = 0;
                ChestManager.Instance.NumberOfCommonPrices --;
                if(ChestManager.Instance.NumberOfCommonPrices==0)
                {
                    ChestManager.Instance.RangeSmaller = 95;
                }
            }
             if(ChestManager.Instance.NumberOfRarePrices<0 && ChestManager.Instance.NumberOfCommonPrices== 0)
             {
                 ChestManager.Instance.PriceIndex = 2;
             }

        

        }

        else if( Percentage < 75)
        {
           ChestManager.Instance.PriceIndex = 0;
           ChestManager.Instance.NumberOfCommonPrices--;
           ChestManager.Instance.RangeSmaller += 10;

           if(ChestManager.Instance.NumberOfCommonPrices == 0 )
           {
               
               ChestManager.Instance.RangeSmaller = 75;
               if(ChestManager.Instance.NumberOfRarePrices <= 0)
               {
                   ChestManager.Instance.RangeSmaller = 95;               
               }
           }
        }
 
        

        if(ChestManager.Instance.AvaliableKeys == 0 && ChestManager.Instance.X3KeysUsed > 0) 
        {
            ChestManager.Instance.X3KeysUsed --;
            EventManager.OnAllKeysUsed.Invoke();
        }
        

        UpdateCoinText();
        ChestManager.Instance.NumberOfAvailableChests--;
        if(ChestManager.Instance.NumberOfAvailableChests != 0)
        {
            EventManager.OnChestOpened.Invoke();
        }
        

    }
    
     private void UpdateCoinText()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        CoinText.text = " " + ChestManager.Instance.Prices[ChestManager.Instance.PriceIndex];
        Destroy(GetComponent<ChestButtonController>());

    }

   /* private void UpdateBgText()
    {
        
        Regards.Sort();
        BgText.text ="" + Regards[0];
    }*/



}
