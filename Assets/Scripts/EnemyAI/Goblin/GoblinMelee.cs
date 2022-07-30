// This is the newer and simpler version of the Archvale melee system, translated from GMS2 to Unity
// Requirements:
// - This script is in the same object as the weapon itself
// - This gameobject has a parent object, that acts as a "rotation anchor"
// - The rotation anchor gameobject has the player object as it's parent
// - This system expects that your weapon sprites are drawn upright, not angled. Sword blades pointing UP.

// The gameobject hierarchy should look like the following:
//
// Player
// - Weapon Anchor
// - - Weapon (includes this script and the weapon sprite renderer)

// Made by Tturna
// 2021-7-29

using UnityEngine;

public class GoblinMelee : MonoBehaviour
{
    [SerializeField, Tooltip("Weapon position offset from the player position. Default: (1, 0, 0)")] Vector2 weaponOffset;  // Recommended: (1, 0, 0)
    [SerializeField, Tooltip("Weapon rotation while idle. Default: 135")] float weaponRot;                                  // Recommended: 135
    [SerializeField, Tooltip("Attack swing speed. Default: 10")] float swingSpeed;                                          // Recommended: 10

    int swing = 1;
    GameObject anchor;
    Vector3 target;
    float swingAngle;
    bool swinging;

    public GameObject Projectile;
    public Transform shootPoint;

    void Start()
    {
        anchor = transform.parent.gameObject;
    }

    void Update()
    {
        //Anchor rotation
        Vector2 mousePos = Input.mousePosition - Camera.main.WorldToScreenPoint(anchor.transform.position);
        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        Vector3 rot = anchor.transform.eulerAngles;
        swingAngle = Mathf.Lerp(swingAngle, swing * 90, Time.deltaTime * swingSpeed);
        rot.z = angle + swingAngle;
        anchor.transform.eulerAngles = rot;
        

        // Weapon rotation
        float t = swing == 1 ? 45 : -45;
        target.z = Mathf.Lerp(target.z, t, Time.deltaTime * swingSpeed);
        if (Mathf.Abs(t - target.z) < 5) swinging = false;
        transform.localRotation = Quaternion.Euler(target);

        void Swing()
        {
            if (swinging) return;

            // Attack
            swing *= -1;
            swinging = true;
            Instantiate(Projectile, shootPoint.position, shootPoint.rotation);
        }
    }
}
