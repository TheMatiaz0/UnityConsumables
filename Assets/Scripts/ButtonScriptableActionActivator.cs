using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScriptableActionActivator : MonoBehaviour
{
    [SerializeField]
    private ScriptableAction<IContext> test;
}
