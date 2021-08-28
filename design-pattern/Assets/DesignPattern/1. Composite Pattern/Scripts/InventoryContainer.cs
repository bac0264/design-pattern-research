using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryContainer : IOperators
{
    public List<IOperators> inventorySlots = new List<IOperators>();
    
    private Transform parent;
    
    private InventorySlot prefab = null;
    
    public int ID { get; set; }

    public void SetPointerClick(Action<IOperators> pointerClick)
    {
        pointerClick += OnPointerClick;
        
        for (int i = 1; i <= 4; i++)
        {
            var resource = new Resource()
            {
                id = i,
            };

            var inventorySlot = LoadResourceController.GetInventorySlot();

            inventorySlot.transform.SetParent(parent);
            inventorySlot.SetData(resource);
            inventorySlot.SetID(i);
            inventorySlot.SetPointerClick(pointerClick);
            
            inventorySlots.Add(inventorySlot);
        }
    }

    public void OnPointerClick(IOperators iOperator)
    {
        for (int i = 0; i < inventorySlots.Count; i++)
        {
            if (inventorySlots[i].ID == iOperator.ID)
            {
                inventorySlots[i].OnPointerClick(inventorySlots[i]);
                break;
            }
        }
    }

    public void SetTransformParent(Transform parent)
    {
        this.parent = parent;
    }
}
