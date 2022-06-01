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

        /*Vector3Int randPos( Vector3Int lastVec, List<Vector3int> listVec) //прошлый вектор
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
                    if (UnityEngine.Random.Range(0, 2) == 0) vec.x++;
                    else vec.y++;
                    break;
                case 5:
                    if (UnityEngine.Random.Range(0, 2) == 0) vec.x--;
                    else vec.y++;
                    break;
            }
            
            return vec;
        }*/

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

        Vector3Int mirror(Vector3Int a, Vector3Int n)// a - отражаемый вектор, n - нормаль в точке пересечения
        {
            Vector3Int b = Vector3Int.zero;
            int k = n.x * a.x + n.y * a.y + n.z * a.z;
            b.x = a.x + n.x * k * -2;
            b.y = a.y + n.y * k * -2;
            b.z = a.z + n.z * k * -2;
            return b;
        }
        Vector3Int setTileVec = new Vector3Int(map.x / 2, 0, -1);
        tilemapRo.SetTile(setTileVec, tilesRo[5]); // начало пути
        roadVec.Add(setTileVec);

        int countTiles = 0;
        while (roadVec[countTiles].y < map.y / 2)
        {
            countTiles++;
            roadVec.Add(randPos(roadVec[countTiles - 1], countTiles));

        };


        /* while (roadVec[countTiles].y < map.y)
         {
             roadVec.Add(mirror(roadVec[invertTiles], new Vector3Int(map.x, map.y, 0)));
             if (countTiles > 100) return;
         }*/

        for (int i = 0; i < roadVec.Count; i++)
        {
            tilemapRo.SetTile(roadVec[i], tilesRo[UnityEngine.Random.Range(0, 8)]);
        }

    }
    void Update()
    {

    }



}
