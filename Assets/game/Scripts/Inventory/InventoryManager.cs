using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private List<ItemData> _item = new List<ItemData>();
    private List<ItemData> Items => _item;


    public void AddItems(ItemData item)
    {
        Items.Add(item);
    }

    public bool CheckItem(string id)
    {
        bool isExsist = Items.Exists(ItemData => string.Equals(ItemData.ID, id));
        return isExsist;
    }

    public void RemoveItem(ItemData item)
    {
        Items.Remove(item);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
