using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    private GameObject camGame;
    private Tilemap tilemap;
    private float camControl;




    void Awake()
    {

        tilemap = GameObject.Find("Graund").GetComponent<Tilemap>();
        camGame = GameObject.Find("Main Camera");



    }

    void Update()
    {
        cameraControl();///!!!!!!!!!!!!!
    }


    private void Start()
    {
        startCamPos();///!!!!!!!!!!!!!
    }

    void startCamPos()
    {
       
       /*
        camGame.transform.position = new Vector3(camGame.transform.position.x, camGame.transform.position.y, -10);
        camControl = camGame.transform.position;
        Debug.Log(camGame.transform.position);*/

    }
    void cameraControl()
    {
        camControl += Input.GetAxis("Horizontal")*0.03f;
        if(camControl <0)
            camControl = 0;
        else if(camControl > 20)
                camControl = 20;
        camGame.transform.position = Vector3.Lerp(camGame.transform.position, new Vector3(camControl, 0, -10), Time.deltaTime * 15);
    }
    public Vector3 mousePosTile()
    {
        Vector3 camWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var cellPosition = tilemap.WorldToCell(camWorldPosition);
        return new Vector3(cellPosition.x + 0.5f, cellPosition.y + 0.5f, cellPosition.z); ;
    }


}
