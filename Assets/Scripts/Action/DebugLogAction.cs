using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogAction : MonoBehaviour, IAction
{
    [TextArea]
    [SerializeField]
    private string message;

    public void Execute()
    {
        Debug.Log(message);
    }
}
