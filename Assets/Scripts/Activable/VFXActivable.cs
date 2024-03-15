using UnityEngine;

public class VFXActivable : MonoBehaviour, IActivable
{
    private const string ENABLED = "_ENABLED";

    [SerializeField]
    private Material vfxMaterial;

    public Material VFXMaterial => vfxMaterial;
    public bool IsActive => vfxMaterial.IsKeywordEnabled(ENABLED);

    public void Activate()
    {
        vfxMaterial.EnableKeyword(ENABLED);
    }

    public void Deactivate()
    {
        vfxMaterial.DisableKeyword(ENABLED);
    }
}
