using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySaver : MonoBehaviour
{
    public static InventorySaver Instance;
    private void Awake()
    {
        Instance = this;
    }
    public List<BagItem> inventoryItemList;
    public BagItem emptyItem;
    public Slot TempSlot;//�����洢slot��Ϣ

    public BagItem ChooseOneItemNotInBag(Slot slot)
    {
        for (int i = 0; i < inventoryItemList.Count; i++)
        {
            if (inventoryItemList[i].isInBag == false)
            {
                inventoryItemList[i].isInBag = true;
                slot.isContainedItem = true;
                return inventoryItemList[i];
            }
        }
        return emptyItem;
    }
}
[Serializable]
public class BagItem
{
    public Item item;
    public int itemAmount;
    public bool isInBag = false;
    public bool isInCombinePanle = false;

    public BagItem(Item itemToAdd, int amount)
    {
        this.item = itemToAdd;
        this.itemAmount = amount;
    }
}
