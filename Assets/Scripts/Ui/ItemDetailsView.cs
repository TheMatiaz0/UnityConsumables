using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemDetailsView : MonoBehaviour, IItemRefresher
{
    [SerializeField]
    private Image thumbnail;

    [SerializeField]
    private TextMeshProUGUI itemName;

    [SerializeField]
    private TextMeshProUGUI itemDescription;

    [SerializeField]
    private Button useItemButton;

    private ItemDefinition currentSelectedItem;

    public void Refresh(ItemDefinition item)
    {
        useItemButton.onClick.RemoveAllListeners();
        currentSelectedItem = item;

        thumbnail.sprite = item.ItemIcon;
        itemName.SetText(item.ItemName);
        itemDescription.SetText(item.ItemDescription);

        useItemButton.onClick.AddListener(UseItem);
    }

    private void UseItem()
    {
        // add inventory context
        currentSelectedItem.UseAction.Execute();
    }
}
