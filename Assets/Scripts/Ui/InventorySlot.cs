using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlotRequirement : MonoBehaviour
{
    [SerializeField]
    private Image itemIcon;

    protected ItemDefinition cachedItemDefinition;

    public void Refresh(ItemDefinition itemDefinition)
    {
        cachedItemDefinition = itemDefinition;
        itemIcon.sprite = itemDefinition.ItemIcon;
    }
}

public class InventorySlot : ItemSlotRequirement, ISubmitHandler, ISelectHandler, IPointerClickHandler
{
    public event Action<ItemDefinition> OnSubmitEvent;
    public event Action<ItemDefinition> OnSelectionChangedEvent;

    public void OnPointerClick(PointerEventData eventData)
    {
        OnSubmitEvent?.Invoke(cachedItemDefinition);
    }

    public void OnSelect(BaseEventData eventData)
    {
        OnSelectionChangedEvent?.Invoke(cachedItemDefinition);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        OnSubmitEvent?.Invoke(cachedItemDefinition);
    }
}
