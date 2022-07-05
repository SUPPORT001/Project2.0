using System.Collections.Generic;
using UnityEngine;

public class Persons : MonoBehaviour
{
    public List<GameObject> persons = new List<GameObject>();
    public List<GameObject> spawner = new List<GameObject>();
    private GameObject personsGO;
    bool side;
    string activePerson;
    
    void Start()
    {
        personsGO = GameObject.Find("Persons");
    }


    void Update()
    {
       
    }
    public void shoosePersonStr(string str) //��� ������
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
                spawnPerson(persons[0], knight.moneyCost, Config.indexPlayer);
                
                break;
            case "archer":
                CripStat.Archer archer = new CripStat.Archer();
                spawnPerson(persons[1], archer.moneyCost, Config.indexPlayer);
                break;
            case "wizard":
                CripStat.Wizard wizard = new CripStat.Wizard();
                spawnPerson(persons[2], wizard.moneyCost, Config.indexPlayer);
                break;
            case "rex":
                CripStat.Rex rex = new CripStat.Rex();
                spawnPerson(persons[3], rex.moneyCost, Config.indexPlayer);
                break;
            case "Tank":
                CripStat.Tank tank = new CripStat.Tank();
                spawnPerson(persons[4], tank.moneyCost, Config.indexPlayer);
              
                break;
        }
    }
    void spawnPerson(GameObject GO, int price, int side)
    {
        if (Input.GetMouseButtonUp(0) && score.moneyP1 >= price)
        {
            string GOname = GO.name;
            GameObject GO2 = new GameObject();
            if (Config.indexPlayer == 0)
            {
                 GO2 = Instantiate(GO, spawner[0].transform.position, Quaternion.identity, personsGO.GetComponent<Transform>());

            }
            else  GO2 = Instantiate(GO, spawner[1].transform.position, Quaternion.Inverse(Quaternion.identity), personsGO.GetComponent<Transform>());
                GO2.name = GOname;
                
            GO2.AddComponent<Crip>();
            GO2.GetComponent<Crip>().side = Config.indexPlayer;
        }
    }


}
