using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlotRequirement : MonoBehaviour
{
    [SerializeField]
    private Image itemIcon;

    protected ItemDefinition itemDefinition;

    public void Refresh(ItemDefinition itemDefinition)
    {
        itemIcon.sprite = itemDefinition.ItemIcon;
    }
}

public class InventorySlot : ItemSlotRequirement, ISubmitHandler, ISelectHandler, IPointerClickHandler
{
    public event Action<ItemDefinition> OnSubmitEvent;
    public event Action<ItemDefinition> OnSelectionChangedEvent;

    public void OnPointerClick(PointerEventData eventData)
    {
        OnSubmitEvent?.Invoke(itemDefinition);
    }

    public void OnSelect(BaseEventData eventData)
    {
        OnSelectionChangedEvent?.Invoke(itemDefinition);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        OnSubmitEvent?.Invoke(itemDefinition);
    }
}
