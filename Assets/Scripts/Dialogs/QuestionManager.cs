using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public Text questionText;
    private Escolha[] escolhas;
    public Button questionButton;
    public Canvas buttonContainer;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void StartQuestion(Questao questao)
    {
        Debug.Log(questao.text);
        Debug.Log(questao.escolhas);

        animator.SetBool("isOpen", true);
        questionText.text = questao.text;

        Debug.Log(questionButton.transform.parent);
        for (int i = 0; i<questao.escolhas.Length; i++)
        {
            int buttonSpacing = -44;
            Button button = Instantiate(questionButton);
            Debug.Log(questao.escolhas[i].text);
            button.transform.GetComponent<Text>().text = questao.escolhas[i].text;
            button.GetComponent<QuestionButton>().setEscolha(questao.escolhas[i]);
            button.transform.SetParent(buttonContainer.transform);
            button.transform.localScale = Vector3.one;
            button.GetComponent<RectTransform>().anchoredPosition = new Vector3(20, i * buttonSpacing, 0);
        }
    }
    
    public void FinishQuestion()
    {
        animator.SetBool("isOpen", false);
    }

}
