using UnityEngine;

public class VFXActivable : MonoBehaviour, IActivable
{
    private const string ENABLED = "_ENABLED";

    [SerializeField]
    private Material vfxMaterial;

    public bool IsActive
    {
        get => vfxMaterial.IsKeywordEnabled(ENABLED);
        private set
        {
            if (value)
            {
                vfxMaterial.EnableKeyword(ENABLED);
            }
            else
            {
                vfxMaterial.DisableKeyword(ENABLED);
            }
        }
    }

    private void Awake()
    {
        Activate();
    }

    public void Activate()
    {
        IsActive = true;
    }

    public void Deactivate()
    {
        IsActive = false;
    }

    private void OnDestroy()
    {
        Deactivate();
    }
}
