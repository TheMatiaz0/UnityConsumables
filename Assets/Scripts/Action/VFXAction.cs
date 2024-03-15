using System.Collections;
using System.Collections.Generic;
using TNRD;
using UnityEngine;

[CreateAssetMenu(fileName = "NewVFXAction", menuName = "Definitions/Action/VFX", order = 70)]
public class VFXAction : ScriptableAction<IItemUseContext>
{
    [SerializeField]
    private Material material;

    [SerializeField]
    private float time;

    public override void Execute(IItemUseContext context)
    {
        context.VFXSystem.AddEffectToQueue(material, time);
    }
}
