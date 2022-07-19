using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOpenClose : MonoBehaviour
{
    public GameObject InventoryObject;
    public Animator invAnim;

    bool invIsOpen;

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
            }
        }
    }

    public void CloseInv()
    {
        InventoryObject.SetActive(false);
    }
}
