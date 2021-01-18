using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestManager : Singleton<ChestManager>
{    
    public List<int> Prices;

    public int PriceIndex;
    
    public int  NumberOfCommonPrices;
    public int NumberOfRarePrices;
    public int NumberOfEpicPrices;
    public int ClosedChests;
    public int AvaliableKeys;
    public int RangeSmaller;
    public int RangeBigger;
    public int X3KeysUsed;
    public int NumberOfAvailableChests;


    


}
