using System.Collections.Generic;
using UnityEngine;

public class Persons : MonoBehaviour
{
    public List<GameObject> persons = new List<GameObject>();
    public List<GameObject> spawner = new List<GameObject>();
    private GameObject personsGO;
    private Vector2Int map;
    string activePerson;
    
    void Start()
    {
        //cripStat = GameObject.Find("Persons").GetComponent<CripStat>();
        map = GameObject.Find("Grid").GetComponent<GraudGaner>().map;
        //Score = GameObject.Find("Canvas").GetComponent<score>();

        //Start spawn pos
        spawner[0].transform.position = new Vector3(map.x / 2, 0, -1);
        spawner[1].transform.position = new Vector3(map.x / 2, map.y, -1);



        personsGO = GameObject.Find("Persons");
    }


    void Update()
    {
        
    }
    public void shoosePersonStr(string str) //Для кнопок
    {
        activePerson = str;
        choosePerson();
    }
    void choosePerson()
    {

        switch (activePerson)
        {
            case "knight":
                CripStat.Knight knight = new CripStat.Knight();
                spawnPerson(persons[0], knight.moneyCost);
                
                break;
            case "archer":
                CripStat.Archer archer = new CripStat.Archer();
                spawnPerson(persons[1], archer.moneyCost);
                break;
            case "wizard":
                CripStat.Wizard wizard = new CripStat.Wizard();
                spawnPerson(persons[2], wizard.moneyCost);
                break;
            case "rex":
                CripStat.Rex rex = new CripStat.Rex();
                spawnPerson(persons[3], rex.moneyCost);
                break;
            case "Tank":
                CripStat.Tank tank = new CripStat.Tank();
                spawnPerson(persons[4], tank.moneyCost);
              
                break;
        }
    }
    void spawnPerson(GameObject GO, int price)
    {
        if (Input.GetMouseButtonUp(0) && score.moneyP1 >= price)
        {
            string GOname = GO.name;
            GameObject GO2 = Instantiate(GO, spawner[0].transform.position, new Quaternion(0, 0, 0, 0), personsGO.GetComponent<Transform>());
            GO2.name = GOname;
            GO2.AddComponent<Crip>();
        }
    }


}
