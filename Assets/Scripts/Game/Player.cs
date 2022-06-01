using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    private GameObject camGame;
    private Tilemap tilemap;
    private Vector3 camControl;
    void Awake()
    {
        tilemap = GameObject.Find("Graund").GetComponent<Tilemap>();
        camGame = GameObject.Find("Main Camera");
    }

    void Update()
    {
        
        cameraControl();
    }




    void cameraControl()
    {
        var camPos = camGame.transform.position;
        camControl += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        camPos = Vector3.Lerp(camPos, new Vector3(camControl.x * 0.03f,camControl.y * 0.03f, -10),  Time.deltaTime* 15 );
        camGame.transform.position = camPos;
    }
    public Vector3Int mousePosTile()
    {
        Vector3 camWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                var cellPosition = tilemap.WorldToCell(camWorldPosition);
        return cellPosition;
    }
}
