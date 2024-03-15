using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableActionActivable : IAction
{
    [SerializeField]
    private bool isActive;

    public void Execute()
    {
        if (isActive)
        {
            // ...?
        }
    }
}
