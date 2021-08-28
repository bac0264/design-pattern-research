using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BaseSlot : MonoBehaviour, IPointerClickHandler, IOperators
{
    [SerializeField] private Image icon;
    
    public Resource resource;

    public int ID { get; set; }
    
    private Action<IOperators> pointerClick;

    public virtual void SetID(int ID)
    {
        this.ID = ID;
    }
    public virtual void SetData(Resource resource)
    {
        this.resource = resource;

        if (resource == null) icon.gameObject.SetActive(false);
        else
        {
            icon.gameObject.SetActive(true);
            icon.sprite = LoadResourceController.GetItemIcon(resource.id);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData != null && (eventData.button == PointerEventData.InputButton.Right || eventData.clickCount > 0))
        {
            if (pointerClick != null)
                pointerClick(this);
        }
    }

    public void SetPointerClick(Action<IOperators> pointerClick)
    {
        this.pointerClick = pointerClick;
    }

    public virtual void OnPointerClick(IOperators resource)
    {
    }
}