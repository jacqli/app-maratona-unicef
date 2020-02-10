using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDialog : MonoBehaviour
{
    public Dialog dialog;

    public void triggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("foi");
        triggerDialog();
    }
}
