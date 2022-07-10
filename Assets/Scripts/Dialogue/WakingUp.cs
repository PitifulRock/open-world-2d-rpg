using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class WakingUp : MonoBehaviour
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
        if (Input.GetKey(KeyCode.E) && DialogManager.Printer.activeInHierarchy == false && (this.transform.position - player.transform.position).sqrMagnitude <= 6)
        {
            StartCoroutine(WaitForAddingText());
        }
    }

    IEnumerator WaitForAddingText()
    {
        var dialogTexts = new List<DialogData>();
        if (DialogManager.Printer.activeInHierarchy == false)
        {
            dialogTexts.Add(new DialogData("Hello?", "Test"));
            dialogTexts.Add(new DialogData("Are you up yet?", "Test"));
            dialogTexts.Add(new DialogData("123456789", "Test"));
            dialogTexts.Add(new DialogData("#^!@*^$%&*^%$^*@&#%$@", "Test"));
            dialogTexts.Add(new DialogData("/size:down/test /size:down/test /size:down/testing...", "Test"));
            yield return new WaitForSeconds(0.1f);
        }
        DialogManager.Show(dialogTexts);
    }
}
