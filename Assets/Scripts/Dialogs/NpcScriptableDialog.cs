using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcScriptableDialog : MonoBehaviour
{
    public ScriptableDialog dialog;

    public void triggerDialog()
    {
        FindObjectOfType<DialogManager>().StartScriptedDialog(dialog);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("foi");
        triggerDialog();
    }
}
