using UnityEngine;

public class BehaviourActivable : MonoBehaviour, IActivable
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
