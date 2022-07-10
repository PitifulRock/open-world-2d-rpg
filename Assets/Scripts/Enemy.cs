using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float EnemyHealth = 10f;
    public float EnemyDamage = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.GetComponent<CharacterControllerTD>().TakeDamage(EnemyDamage);
        }
    }

    public void TakeDamage(float damageAmount)
    {
        EnemyHealth = EnemyHealth - damageAmount;
    }
}
