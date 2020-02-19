using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu(fileName ="Question", menuName ="Question")]
public class ScriptableQuestion : ScriptableObject
{
    //eu acho q essa classe não esta sendo usada
    [TextArea(2, 5)]
    public string text;
    public Dialog dialog;
    public bool stopPlayer;
}
