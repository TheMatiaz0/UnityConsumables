using UnityEngine;

public class DrunkVFXActivable : MonoBehaviour, IActivable
{
    private const string WAVE_SCALE = "_Wave_Scale";
    private const string VORONOI_SCALE = "_Voronoi_Scale";

    [SerializeField]
    private Vector2 minMaxWaveScale = new(0.012f, 0.017f);

    [SerializeField]
    private float voronoiScale = 0.0014f;

    [SerializeField]
    private Material fullscreenMaterial;

    private Vector4 WaveScale
    {
        get => fullscreenMaterial.GetVector(WAVE_SCALE);
        set
        {
            fullscreenMaterial.SetVector(WAVE_SCALE, value);
        }
    }
    private float VoronoiScale
    {
        get => fullscreenMaterial.GetFloat(VORONOI_SCALE);
        set
        {
            fullscreenMaterial.SetFloat(VORONOI_SCALE, value);
        }
    }

    public bool IsActive => !(WaveScale == Vector4.zero || VoronoiScale == 0); 

    private void Awake()
    {
        Activate();
    }

    public void Activate()
    {
        WaveScale = new(minMaxWaveScale.x, minMaxWaveScale.y);
        VoronoiScale = voronoiScale;
    }

    public void Deactivate()
    {
        WaveScale = Vector4.zero;
        VoronoiScale = 0;
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
