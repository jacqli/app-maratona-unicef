using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[System.Serializable]
public class EventoModificarDialog: UnityEvent<ScriptableDialog> { }


public class QuestaoController : MonoBehaviour
{
    public Escolha escolha;
    public EventoModificarDialog eventoModificarDialog;

    public static QuestaoController AddBotaoEscolha(Button templateBotao, Escolha escolha, int index)
    {
        int buttonSpacing = -44;
        Button button = Instantiate(templateBotao);
        
        button.transform.SetParent(templateBotao.transform.parent);
        button.transform.localScale = Vector3.one;
        button.transform.localPosition = new Vector3(0, index * buttonSpacing, 0);
        button.name = "Choice " + (index + 1);
        button.gameObject.SetActive(true);

        QuestaoController questaoController = button.GetComponent<QuestaoController>();
        questaoController.escolha = escolha;
        return questaoController;
    }
    public void MakeChoice()
    {
        eventoModificarDialog.Invoke(escolha.dialog);
    }


    /*
        private void Start()
        {
            if (eventoModificarDialog == null)
                eventoModificarDialog = new EventoModificarDialog();
            GetComponent<Button>().GetComponentInChildren<Text>().text = escolha.text;

        }
        */
}
