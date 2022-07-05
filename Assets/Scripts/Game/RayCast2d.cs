using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast2d : MonoBehaviour
{
  
    void Update()
    {
      
    }
    public string Hit()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            return hit.collider.gameObject.tag;

        }
        return null;
    }
}
