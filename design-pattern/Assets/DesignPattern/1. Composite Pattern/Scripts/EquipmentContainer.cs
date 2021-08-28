using System;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentContainer : IOperators
{
    public List<IOperators> equipmentSlots = new List<IOperators>();
    public int ID { get; set; }
    private Transform parent;
    
    public void SetPointerClick(Action<IOperators> pointerClick)
    {
        pointerClick += OnPointerClick;
        
        for (int i = 1; i <= 4; i++)
        {
            var equip = LoadResourceController.GetEquipSlot();

            equip.transform.SetParent(parent);
            equip.SetData(null);
            equip.SetID(i);

            equip.SetPointerClick(pointerClick);
            
            equipmentSlots.Add(equip);
        }
        
    }

    public void OnPointerClick(IOperators iOperator)
    {
        for (int i = 0; i < equipmentSlots.Count; i++)
        {
            if (equipmentSlots[i].ID == iOperator.ID)
            {
                equipmentSlots[i].OnPointerClick(iOperator);
                break;
            }
        }
    }

    public void SetTransformParent(Transform parent)
    {
        this.parent = parent;
    }
}