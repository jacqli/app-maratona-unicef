using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialog", menuName = "Dialog")]
public class ScriptableDialog : ScriptableObject
{
    [TextArea(2, 10)]
    public string[] sentencas;
    public string nome;
    public Questao nextQuestion;
    public bool stopPlayer; 
}
