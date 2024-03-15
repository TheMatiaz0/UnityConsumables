using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemDetailsView : MonoBehaviour
{
    [SerializeField]
    private GameObject root;

    [SerializeField]
    private Image thumbnail;

    [SerializeField]
    private TextMeshProUGUI itemName;

    [SerializeField]
    private TextMeshProUGUI itemDescription;

    [SerializeField]
    private Button useItemButton;

    private ItemDefinition currentSelectedItem;
    private IItemUseContext currentItemContext;

    public void Refresh(ItemDefinition item, IItemUseContext itemUseContext = null)
    {
        root.SetActive(item != null);
        if (item == null)
        {
            return;
        }

        useItemButton.onClick.RemoveAllListeners();

        currentSelectedItem = item;
        currentItemContext = itemUseContext;

        thumbnail.sprite = item.ItemIcon;
        itemName.SetText(item.ItemName);
        itemDescription.SetText(item.ItemDescription);

        useItemButton.onClick.AddListener(UseItem);
    }

    private void UseItem()
    {
        if (currentItemContext != null)
        {
            currentSelectedItem.UseAction.Execute(currentItemContext);
        }
    }
}
