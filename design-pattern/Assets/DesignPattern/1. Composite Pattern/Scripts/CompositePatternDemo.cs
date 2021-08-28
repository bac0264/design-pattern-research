using System;
using UnityEngine;

public class CompositePatternDemo : MonoBehaviour
{
    public int ID { get; set; }

    private IOperators _inventoryContainer;

    private IOperators InventoryContainer
    {
        get
        {
            if (_inventoryContainer == null)
            {
                var container = new InventoryContainer();
                var inventoryTransform = GameObject.Find("inventory_container").transform;

                container.SetTransformParent(inventoryTransform);

                _inventoryContainer = container;
            }

            return _inventoryContainer;
        }
    }

    private IOperators _equipmentContainer;

    private IOperators EquipmentContainer
    {
        get
        {
            if (_equipmentContainer == null)
            {
                var container = new EquipmentContainer();
                var inventoryTransform = GameObject.Find("equipment_container").transform;

                container.SetTransformParent(inventoryTransform);
                _equipmentContainer = container;
            }

            return _equipmentContainer;
        }
    }


    private void Awake()
    {
        SetPointerClick();
    }

    public void SetPointerClick()
    {
        InventoryContainer.SetPointerClick(UnEquip);
        EquipmentContainer.SetPointerClick(Equip);
    }

    private void Equip(IOperators equip)
    {
        InventoryContainer.OnPointerClick(equip);
    }
    
    private void UnEquip(IOperators equip)
    {
        EquipmentContainer.OnPointerClick(equip);
    }
}