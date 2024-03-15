using UnityEngine;

public class VFXActivable : MonoBehaviour, IActivable
{
    private const string ENABLED = "_ENABLED";

    [SerializeField]
    private Material vfxMaterial;

    public bool IsActive => vfxMaterial.IsKeywordEnabled(ENABLED);

    private void Awake()
    {
        Activate();
    }

    public void Activate()
    {
        vfxMaterial.EnableKeyword(ENABLED);
    }

    public void Deactivate()
    {
        vfxMaterial.DisableKeyword(ENABLED);
    }

    private void OnDestroy()
    {
        Deactivate();
    }
}
