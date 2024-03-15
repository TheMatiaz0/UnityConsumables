using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlotRequirement : MonoBehaviour
{
    [SerializeField]
    private Image itemIcon;

    public void Refresh(ItemDefinition itemDefinition)
    {
        itemIcon.sprite = itemDefinition.ItemIcon;
    }
}

public class InventorySlot : ItemSlotRequirement, ISubmitHandler, ISelectHandler, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("pointer submit");
    }

    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log("select");
    }

    public void OnSubmit(BaseEventData eventData)
    {
        // use ItemAction from Inventory here..
        Debug.Log("submit");
    }
}
