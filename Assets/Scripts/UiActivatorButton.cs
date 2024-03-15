using System.Collections;
using System.Collections.Generic;
using TNRD;
using UnityEngine;
using UnityEngine.UI;

public class UiActivatorButton : MonoBehaviour
{
    [SerializeField]
    private bool shouldActivate;

    [SerializeField]
    private SerializableInterface<IUiContext> context;

    [SerializeField]
    private Button button;

    private void OnEnable()
    {
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        if (shouldActivate)
        {
            context.Value.InventoryView.Activate();
        }
        else
        {
            context.Value.InventoryView.Deactivate();
        }
    }
}
