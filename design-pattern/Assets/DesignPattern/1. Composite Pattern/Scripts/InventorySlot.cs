using UnityEngine;

public class InventorySlot : BaseSlot
{
    [SerializeField] private GameObject hide;

    public override void SetData(Resource resource)
    {
        base.SetData(resource);
        
        hide.SetActive(resource.isEquip);
    }

    public override void OnPointerClick(IOperators iOperator)
    {
        resource.isEquip = !resource.isEquip;

        SetData(resource);
    }
}