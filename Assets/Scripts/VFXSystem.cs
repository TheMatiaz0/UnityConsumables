using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXTimedActivable
{
    public VFXActivable Activable;
    public float? Time;

    public VFXTimedActivable(VFXActivable activable, float? time)
    {
        Activable = activable;
        Time = time;
    }
}

public class VFXSystem : MonoBehaviour
{
    private Queue<VFXTimedActivable> vfxActivables = new();
    private Coroutine processVFXCoroutine;

    private void Start()
    {
        processVFXCoroutine = StartCoroutine(Process());
    }

    public void AddEffectToQueue(VFXTimedActivable activable)
    {
        vfxActivables.Enqueue(activable);

        if (processVFXCoroutine == null)
        {
            StartCoroutine(Process());
        }
    }

    private IEnumerator Process()
    {
        while (vfxActivables.Count > 0)
        {
            VFXTimedActivable timedActivable;
            yield return (timedActivable = vfxActivables.Dequeue());

            timedActivable.Activable.Activate();
            if (timedActivable.Time.HasValue || timedActivable.Time == 0)
            {
                yield return new WaitForSeconds(timedActivable.Time.Value);
                timedActivable.Activable.Deactivate();
            }
        }

        processVFXCoroutine = null;
    }
}
