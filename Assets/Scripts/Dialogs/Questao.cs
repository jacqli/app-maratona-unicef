
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Escolha
{
    [TextArea(2, 5)]
    public string text;
    public ScriptableDialog dialog;
}

[CreateAssetMenu(fileName = "Nova Questao", menuName= "Questao")]
public class Questao: ScriptableObject
{
    [TextArea(2, 5)]
    public string text;
    public Escolha[] escolhas;
    public bool stopPlayer;
}