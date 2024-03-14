using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, ISubmitHandler, ISelectHandler, IPointerClickHandler
{
    [SerializeField]
    private Image itemIcon;

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
