using UnityEngine;
using UnityEngine.Tilemaps;
using Photon.Pun;

public class Player : MonoBehaviour
{
    private GameObject camGame;
    private Tilemap tilemap;
    private float camControl;

    private PhotonView photonView;


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
        photonView = GetComponent<PhotonView>();
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
        if (!photonView.IsMine) return;
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
