using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast2d : MonoBehaviour
{
  
    void Update()
    {
        Debug.Log(Hit());       
    }
    public Vector3 Hit()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            return hit.collider.GetComponent<RectTransform>().sizeDelta;

        }
        return Vector3.zero;
    }
}
