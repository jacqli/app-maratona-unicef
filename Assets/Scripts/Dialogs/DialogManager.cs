using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    private Queue<string> sentencas;
    public Text nameText;
    public Text sentenceText;
    public Questao nextQuestion;

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

    public void StartScriptedDialog(ScriptableDialog dialog)
    {
        Debug.Log("dialog with " + dialog.nome);

        FindObjectOfType<PlayerMov>().canMove = false;
        animator.SetBool("isOpen", true);
        nameText.text = dialog.nome;
        sentencas.Clear();
        nextQuestion = dialog.nextQuestion;

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

        FindObjectOfType<PlayerMov>().canMove = true;
        animator.SetBool("isOpen", false);
        Debug.Log(nextQuestion);
        Debug.Log("fim de dialogo");
        if(nextQuestion != null)
            FindObjectOfType<QuestionManager>().StartQuestion(nextQuestion);
    }

}
