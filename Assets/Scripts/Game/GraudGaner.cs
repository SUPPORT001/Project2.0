using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GraudGaner : MonoBehaviour
{

    private Tilemap tilemapGr;
    private Tilemap tilemapRo;

    public List<TileBase> tilesGr = new List<TileBase>();
    public List<TileBase> tilesRo = new List<TileBase>();
    public List<TileBase> tilesEr = new List<TileBase>();
    public Vector2Int map;
    public List<Vector3Int> roadVec = new List<Vector3Int>();

    void Awake()
    {
        tilemapGr = GameObject.Find("Graund").GetComponent<Tilemap>();
        tilemapRo = GameObject.Find("Road").GetComponent<Tilemap>();
        LineReposition();
    }

    private void Start()
    {
        graundGener();
        RoadGener();
        
    }
    void graundGener()
    {

        for (int Y = 0; Y < map.y + 1; Y++)
        {
            for (int X = 0; X < map.x + 1; X++)
            {
                //Генерация земли
                tilemapGr.SetTile(new Vector3Int(X, Y, 0), tilesGr[UnityEngine.Random.Range(0, tilesGr.Count)]);
            }
        }
    }
    void LineReposition()
    {
        GameObject line = GameObject.Find("line");
        Vector3 lineCen = tilemapGr.CellToWorld(new Vector3Int(map.x / 2, (map.y / 2), 0));
        line.transform.position = new Vector3(lineCen.x + 0.5f, lineCen.y + 0.50f, lineCen.z);
    }
    void RoadGener()
    {
        Vector3Int randPos(Vector3Int lastVec, int count) //прошлый вектор
        {
            Vector3Int vec = lastVec;

            if (count % 2 == 0)
            {
                vec.y++;
            }
            else if (UnityEngine.Random.Range(0, 2) == 0)
            {
                vec.x++;
            }
            else vec.x--;

            return vec;
        }

        Vector3Int setTileVec = new Vector3Int(map.x / 2, 0, -1);
        /*tilemapRo.SetTile(setTileVec, tilesRo[5]); // начало пути*/
        roadVec.Add(setTileVec);

        int countTiles = 0;
        while (roadVec[countTiles].y < (1+map.y) / 2 )
        {
            countTiles++;
            roadVec.Add(randPos(roadVec[countTiles - 1], countTiles));

        };

        for (; countTiles > 0; --countTiles)
        {
            roadVec.Add(new Vector3Int(roadVec[countTiles - 1].x, -roadVec[countTiles - 1].y + map.y, roadVec[countTiles - 1].z));
            
        };

        for (int i = 0; i < roadVec.Count; i++) // Отрисовка векторов и земли
        {
            /*
                        tilemapRo.SetTile(roadVec[i], tilesRo[UnityEngine.Random.Range(0, 8)]);
                        tilemapRo.SetTile(new Vector3Int(roadVec[i].x - 1, roadVec[i].y, roadVec[i].z ), tilesRo[UnityEngine.Random.Range(0, 8)]);
                        tilemapRo.SetTile(new Vector3Int(roadVec[i].x + 1, roadVec[i].y, roadVec[i].z ), tilesRo[UnityEngine.Random.Range(0, 8)]);
            */
            tilemapRo.SetTile(roadVec[i], tilesEr[UnityEngine.Random.Range(0, 7)]);
            tilemapRo.SetTile(new Vector3Int(roadVec[i].x - 1, roadVec[i].y, roadVec[i].z), tilesEr[UnityEngine.Random.Range(0, 7)]);
            tilemapRo.SetTile(new Vector3Int(roadVec[i].x + 1, roadVec[i].y, roadVec[i].z), tilesEr[UnityEngine.Random.Range(0, 7)]);
        }

    }

    void Update()
    {

    }


}
