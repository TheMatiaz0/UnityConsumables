using UnityEngine;

public class ActivableBehaviour : MonoBehaviour, IActivable
{
    [SerializeField]
    private Behaviour behaviour;

    public bool IsActive => behaviour.enabled;

    public void Activate()
    {
        behaviour.enabled = true;
    }

    public void Deactivate()
    {
        behaviour.enabled = false;
    }
}
