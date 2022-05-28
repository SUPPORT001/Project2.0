using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GraudGaner : MonoBehaviour
{
    private Tilemap tilemap;
    public List<TileBase> tiles = new List<TileBase>();
    public Vector2Int map;

    void Awake()
    {
        tilemap = GameObject.Find("Graund").GetComponent<Tilemap>();
    }

    private void Start()
    {
        for (int Y = 0; Y < map.y + 1; Y++)
        {
            for (int X = 0; X < map.x + 1; X++)
            {
                tilemap.SetTile(new Vector3Int(X, Y, 0), tiles[UnityEngine.Random.Range(0, tiles.Count)]);
                print(X + " " + Y);

            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }



}
