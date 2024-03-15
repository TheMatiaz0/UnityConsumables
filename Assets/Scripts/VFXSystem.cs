using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class VFXTimedActivable
{
    public VFXActivable Activable;
    public float Time;

    public VFXTimedActivable(VFXActivable activable, float time)
    {
        Activable = activable;
        Time = time;
    }
}

public class VFXSystem : MonoBehaviour
{
    [SerializeField]
    private List<VFXTimedActivable> activables = new();

    private readonly Queue<VFXTimedActivable> vfxActivableQueue = new();
    private Coroutine processVFXCoroutine;

    private void Start()
    {
        // vfxActivableQueue = new(activables);
        processVFXCoroutine = StartCoroutine(Process());
    }

    public void AddEffectToQueue(Material vfxMaterial, float time)
    {
        var activable = activables.Find(x => vfxMaterial == x.Activable.VFXMaterial);
        vfxActivableQueue.Enqueue(new(activable.Activable, time));

        if (processVFXCoroutine == null)
        {
            StartCoroutine(Process());
        }
    }

    private IEnumerator Process()
    {
        while (vfxActivableQueue.Count > 0)
        {
            VFXTimedActivable timedActivable;
            yield return (timedActivable = vfxActivableQueue.Dequeue());

            timedActivable.Activable.Activate();
            yield return new WaitForSeconds(timedActivable.Time);
            timedActivable.Activable.Deactivate();
        }

        processVFXCoroutine = null;
    }
}
