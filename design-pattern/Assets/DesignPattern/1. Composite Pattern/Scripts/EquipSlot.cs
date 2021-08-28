public class EquipSlot : BaseSlot
{
    public override void OnPointerClick(IOperators iOperator)
    {
        if (resource != null)
            resource = null;
        else
        {
            if (iOperator is BaseSlot baseSlot)
            {
                resource = baseSlot.resource;
            }
        }
        SetData(resource);
    }
}