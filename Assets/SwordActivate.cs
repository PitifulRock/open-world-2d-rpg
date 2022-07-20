using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordActivate : MonoBehaviour
{
    private Transform swordHolder;
    [SerializeField] GameObject sword;

    // Start is called before the first frame update
    void Start()
    {
        swordHolder = GameObject.FindGameObjectWithTag("SwordHolder").transform;
    }

    public void ActivateSword()
    {
        if(swordHolder.childCount <= 0)
        {
            Instantiate(sword, swordHolder);
        }
        else if(swordHolder.childCount > 0)
        {
            foreach (Transform child in swordHolder)
            {
                GameObject.Destroy(child.gameObject);
            }
            Instantiate(sword, swordHolder);
        }
    }
}
