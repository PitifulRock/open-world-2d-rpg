using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public float SwingSpeed = 1;
    public float cooldown;
    public Transform upPoint;
    public Transform downPoint;

    private bool CurrentlyUp = true;
    private bool canShoot;

    public GameObject MeleeProjectile;
    public Transform shootPoint;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canShoot)
        {
            Instantiate(MeleeProjectile, shootPoint.position, shootPoint.rotation);
            if (CurrentlyUp == true && canShoot)
            {
                MoveDown();
                StartCoroutine(CooldownHandle());
            }
            else if (CurrentlyUp == false && canShoot)
            {
                MoveUp();
                StartCoroutine(CooldownHandle());
            }
            
        }
    }

    private void MoveUp()
    {
        transform.position = Vector3.Lerp(downPoint.position, upPoint.position, SwingSpeed);
        transform.rotation = upPoint.rotation;

        CurrentlyUp = true;
    }

    private void MoveDown()
    {
        transform.position = Vector3.Lerp(upPoint.position, downPoint.position, SwingSpeed);
        transform.rotation = downPoint.rotation;

        CurrentlyUp = false;
    }

    IEnumerator CooldownHandle()
    {
        canShoot = false;
        yield return new WaitForSeconds(cooldown);
        canShoot = true;
    }
}
