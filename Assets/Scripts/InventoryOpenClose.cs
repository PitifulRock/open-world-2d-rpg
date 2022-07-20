using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class InventoryOpenClose : MonoBehaviour
{
    public GameObject InventoryObject;
    public Animator invAnim;

    bool invIsOpen;

    [SerializeField] AudioMixer MasterMix;

    // Start is called before the first frame update
    void Start()
    {
        InventoryObject.SetActive(false);
        invIsOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (invIsOpen == false)
            {
                InventoryObject.SetActive(true);
                invIsOpen = true;
                invAnim.SetTrigger("InvOpen");
            }
            else
            {
                invIsOpen = false;
                invAnim.SetTrigger("InvClose");
                Time.timeScale = 1;
            }
        }
    }

    public void CloseInv()
    {
        InventoryObject.SetActive(false);
    }

    public void OpenIv()
    {
        Time.timeScale = 0;
    }
}
