using UnityEngine;

public class DrunkVFXController : MonoBehaviour
{
    private const string WAVE_SCALE = "_Wave_Scale";
    private const string VORONOI_SCALE = "_Voronoi_Scale";

    [SerializeField]
    private Vector2 minMaxWaveScale = new(0.012f, 0.017f);

    [SerializeField]
    private float voronoiScale = 0.0014f;

    [SerializeField]
    private Material _fullscreenMaterial;

    private void Awake()
    {
        Activate();
    }

    public void Activate()
    {
        _fullscreenMaterial.SetVector(WAVE_SCALE, new Vector4(minMaxWaveScale.x, minMaxWaveScale.y));
        _fullscreenMaterial.SetFloat(VORONOI_SCALE, voronoiScale);
    }

    public void Deactivate()
    {
        _fullscreenMaterial.SetVector(WAVE_SCALE, new Vector4(0, 0));
        _fullscreenMaterial.SetFloat(VORONOI_SCALE, 0);
    }

    private void OnDestroy()
    {
        Deactivate();
    }

#if UNITY_EDITOR

    private void OnValidate()
    {
        Deactivate();
    }

#endif
}
