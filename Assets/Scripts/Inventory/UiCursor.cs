using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiCursor : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        Vector2 cursorPos = Camera.main.transform.InverseTransformPoint(Input.mousePosition);

        transform.position = cursorPos;
    }
}