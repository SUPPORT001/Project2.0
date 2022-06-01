using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GraudGaner : MonoBehaviour
{
    private Tilemap tilemapGr;
    private Tilemap tilemapRo;
    public List<TileBase> tilesGr = new List<TileBase>();
    public List<TileBase> tilesRo = new List<TileBase>();
    public Vector2Int map;
    public List<Vector3Int> roadVec = new List<Vector3Int>();

    void Awake()
    {
        tilemapGr = GameObject.Find("Graund").GetComponent<Tilemap>();
        tilemapRo = GameObject.Find("Road").GetComponent<Tilemap>();
    }

    private void Start()
    {
        for (int Y = 0; Y < map.y + 1; Y++)
        {
            for (int X = 0; X < map.x + 1; X++)
            {
                //Генерация земли
                tilemapGr.SetTile(new Vector3Int(X, Y, 0), tilesGr[UnityEngine.Random.Range(0, tilesGr.Count)]);



            }
        }
        RoadGener();
    }
    void RoadGener()
    {

        Vector3Int randPos( Vector3Int lastVec) //1 меняемый вектор 2 прошлый вектор
        {
            Vector3Int vec = lastVec;
            switch (UnityEngine.Random.Range(1, 4))
            {
                case 1:
                    if (lastVec == new Vector3Int(vec.x - 1, vec.y, vec.z)) goto case 4;
                    else vec.x--;
                    
                    break;
                case 2:
                    if (lastVec == new Vector3Int(vec.x + 1, vec.y, vec.z)) goto case 5;
                    else vec.x++;
                    break;
                case 3:
                    vec.y++;
                    break;
                case 4:
                    if(UnityEngine.Random.Range(0,2) == 0) vec.x++;
                    else vec.y++;
                    break;
                case 5:
                    if (UnityEngine.Random.Range(0, 2) == 0) vec.x--;
                    else vec.y++;
                    break;
            }
            
            return vec;
        }
        Vector3Int setTileVec = new Vector3Int(map.x / 2, 0, -1);
        tilemapRo.SetTile(setTileVec, tilesRo[5]); // начало пути
        roadVec.Add(setTileVec);

        int countTiles = 0;
        while (roadVec[countTiles].y < map.y / 2)
        {
            countTiles++;
            roadVec.Add(randPos(roadVec[countTiles - 1])) ;
            
            Debug.Log(roadVec[countTiles] + " " + countTiles);
            //tilemapRo.SetTile(randPos(setTileVec, roadVec[countTiles - 1]), tilesRo[Random.Range(0,tilesGr.Count)]);
            //setTileVec[countTiles]= 
            if (countTiles > 10000) return;
        };

        for(int i = 0; i < roadVec.Count; i++)
        {
            tilemapRo.SetTile(roadVec[i], tilesRo[UnityEngine.Random.Range(0,8)]);
        }
      
    }
    void Update()
    {

    }



}
