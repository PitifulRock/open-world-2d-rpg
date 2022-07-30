using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterScene : MonoBehaviour
{
    public string SceneToLoad;

    public float nextSceneX;
    public float nextSceneY;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Vector2 tpPos = new Vector2(nextSceneX, nextSceneY);

        if (other.CompareTag("Player") && !other.isTrigger)
        {
            other.transform.position = tpPos;
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}
