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

        cameraControl();///!!!!!!!!!!!!!
    }


    private void Start()
    {
        startCamPos();///!!!!!!!!!!!!!
    }

    void startCamPos()
    {
        Vector2Int map = GameObject.Find("Grid").GetComponent<GraudGaner>().map;
        camGame.transform.position = tilemap.CellToWorld(new Vector3Int(map.x / 2, map.y / 2, 0));
        camGame.transform.position = new Vector3(camGame.transform.position.x, camGame.transform.position.y, -10);
        camControl = camGame.transform.position;
        Debug.Log(camGame.transform.position);
        
    }
    void cameraControl()
    {
        camControl += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        camGame.transform.position = Vector3.Lerp(camGame.transform.position, new Vector3(camControl.x * 0.03f, camControl.y * 0.03f, -10), Time.deltaTime * 15);
    }
    public Vector3Int mousePosTile()
    {
        Vector3 camWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var cellPosition = tilemap.WorldToCell(camWorldPosition);
        return cellPosition;
    }
}
