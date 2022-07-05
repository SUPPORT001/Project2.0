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
        if (Input.GetKeyUp(KeyCode.R)) {
            side = !side;
        Debug.Log("acho");}
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
                spawnPerson(persons[0], knight.moneyCost,side);
                
                break;
            case "archer":
                CripStat.Archer archer = new CripStat.Archer();
                spawnPerson(persons[1], archer.moneyCost, side);
                break;
            case "wizard":
                CripStat.Wizard wizard = new CripStat.Wizard();
                spawnPerson(persons[2], wizard.moneyCost, side);
                break;
            case "rex":
                CripStat.Rex rex = new CripStat.Rex();
                spawnPerson(persons[3], rex.moneyCost, side);
                break;
            case "Tank":
                CripStat.Tank tank = new CripStat.Tank();
                spawnPerson(persons[4], tank.moneyCost, side);
              
                break;
        }
    }
    void spawnPerson(GameObject GO, int price, bool side)
    {
        if (Input.GetMouseButtonUp(0) && score.moneyP1 >= price)
        {
            string GOname = GO.name;
            GameObject GO2 = new GameObject();
            if (side)
            {
                 GO2 = Instantiate(GO, spawner[0].transform.position, new Quaternion(0, 0, 0, 0), personsGO.GetComponent<Transform>());

            }
            else  GO2 = Instantiate(GO, spawner[1].transform.position, new Quaternion(0, 0, 0, 0), personsGO.GetComponent<Transform>());
                GO2.name = GOname;
                
            GO2.AddComponent<Crip>();
            GO2.GetComponent<Crip>().side = side;
        }
    }


}
