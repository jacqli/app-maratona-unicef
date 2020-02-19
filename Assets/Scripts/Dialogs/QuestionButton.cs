using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionButton : MonoBehaviour
{
    private Escolha escolha;

    public void setEscolha(Escolha esc)
    {
        escolha = esc;
        Debug.Log("a escolha é " + esc.text);
    }

    public void StartEscolhaDialog()
    {
        Debug.Log("escolha selecionada");
        FindObjectOfType<QuestionManager>().FinishQuestion();
        FindObjectOfType<DialogManager>().StartScriptedDialog(escolha.dialog);
    }
}
