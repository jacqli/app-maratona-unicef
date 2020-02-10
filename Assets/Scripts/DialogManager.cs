using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    private Queue<string> sentencas;
    public Text nameText;
    public Text sentenceText;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        sentencas = new Queue<string>();
    }

    public void StartDialog(Dialog dialog)
    {
        Debug.Log("dialog with " + dialog.nome);

        animator.SetBool("isOpen", true);
        nameText.text = dialog.nome;
        sentencas.Clear();

        foreach (string sentenca in dialog.sentencas)
        {
            sentencas.Enqueue(sentenca);
        }
        GoNextSentence();
    }

    public void GoNextSentence()
    {
        if (sentencas.Count == 0)
        {
            FinishDialog();
            return;
        }
        string sentencaAtual = sentencas.Dequeue();
        sentenceText.text = sentencaAtual; 
        Debug.Log(sentencaAtual);
    }
    public void FinishDialog()
    {
        animator.SetBool("isOpen", false);
        Debug.Log("fim de dialogo");
    }

}
