using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Towers : MonoBehaviour
{
    public List<GameObject> tower = new List<GameObject>();
    private GameObject towersGO;
    public string activeTower;
    private bool isActive;
    private GameObject game;
    private score Score;
    private Player PlayerScr;
    private bool isTowerVisible = true;
    private GameObject visibleTower;
    private Tilemap tilemap;
    void Start()
    {
        tilemap = GameObject.Find("Graund").GetComponent<Tilemap>();
        towersGO = GameObject.Find("Towers");
        Score = gameObject.GetComponentInParent<score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive) //Активируется после нажатия пользователем кнопку башни
        {
            chooseTower();
        }
    }
    public void shooseTowerStr(string str) //Для кнопок
    {
        isTowerVisible = true;
        visibleTower = null;
        activeTower = str;
        isActive = true;
        
    }
    GameObject chooseTower()
    {
        switch (activeTower)
        {
            case "knight":
               
                spawnTower(tower[0], 100);
                break;
            case "arches":
                spawnTower(tower[1], 100);
                break;
        }
        var asd = this.gameObject;
        return asd;
    }
    void spawnTower(GameObject GO, ulong price)
    {
        if (isTowerVisible) //Появлевние объекта (Превью постройки)
        {
            visibleTower = Instantiate(GO, GetComponentInParent<Player>().mousePosTile(), new Quaternion(0, 0, 0, 0), towersGO.GetComponent<Transform>());
            isTowerVisible = false;
            
        }
        else
        { //Следование за курсором(превью)
            Vector3 camWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var cellPosition = tilemap.WorldToCell(camWorldPosition);
            visibleTower.transform.position = cellPosition;

        }
        
        if (Input.GetMouseButtonUp(0) && Score.moneyP1 >= price ) //Условие если мышь отжата и денег достаточно
        {
            Instantiate(GO, GetComponentInParent<Player>().mousePosTile(), new Quaternion(0, 0, 0, 0), towersGO.GetComponent<Transform>()); //Сделать проверку на препятствие
            
        }
        else if (Input.GetMouseButtonUp(1))//Отмена 
        {
            Destroy(visibleTower);
            isTowerVisible = true;
            isActive = false;
        }
        
    }
    
}
