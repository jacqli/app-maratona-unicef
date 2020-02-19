using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog 
{
    [TextArea(2, 10)]
    public string[] sentencas;
    public string nome;
    public Questao nextQuestion;
}
