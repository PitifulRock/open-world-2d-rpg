using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class LAsign : MonoBehaviour
{
    public DialogManager DialogManager;

    private GameObject player;

    private void Start()
    {
        DialogManager = GameObject.FindGameObjectWithTag("DDmanager").GetComponent<DialogManager>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && DialogManager.Printer.activeInHierarchy == false && (this.transform.position - player.transform.position).sqrMagnitude <= 6)
        {
            StartCoroutine(WaitForAddingText());
        }
    }

    IEnumerator WaitForAddingText()
    {
        var dialogTexts = new List<DialogData>();
        if (DialogManager.Printer.activeInHierarchy == false)
        {
            dialogTexts.Add(new DialogData("Pastries >\n< Maps", "Test"));
            yield return new WaitForSeconds(0.1f);
        }
        DialogManager.Show(dialogTexts);
    }
}
