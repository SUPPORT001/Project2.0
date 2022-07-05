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
<<<<<<< HEAD
=======




>>>>>>> d7c4113cb780066d2ce55e9622877750b0bd2eba
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
<<<<<<< HEAD
                spawnPerson(persons[0], knight.moneyCost, Config.indexPlayer);
                
=======
                spawnPerson(persons[0], knight.moneyCost, side);

>>>>>>> d7c4113cb780066d2ce55e9622877750b0bd2eba
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
<<<<<<< HEAD
                spawnPerson(persons[4], tank.moneyCost, Config.indexPlayer);
              
=======
                spawnPerson(persons[4], tank.moneyCost, side);

>>>>>>> d7c4113cb780066d2ce55e9622877750b0bd2eba
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
<<<<<<< HEAD
                 GO2 = Instantiate(GO, spawner[0].transform.position, Quaternion.identity, personsGO.GetComponent<Transform>());

            }
            else  GO2 = Instantiate(GO, spawner[1].transform.position, Quaternion.Inverse(Quaternion.identity), personsGO.GetComponent<Transform>());
=======
                GO2 = Instantiate(GO, spawner[0].transform.position, new Quaternion(0, 0, 0, 0), personsGO.GetComponent<Transform>());

            }
            else
            {
                GO2 = Instantiate(GO, spawner[1].transform.position, new Quaternion(0, 0, 0, 0), personsGO.GetComponent<Transform>());
>>>>>>> d7c4113cb780066d2ce55e9622877750b0bd2eba
                GO2.name = GOname;
                GO2.GetComponent<SpriteRenderer>().flipX = true;
            }
            GO2.AddComponent<Crip>();
            GO2.GetComponent<Crip>().side = Config.indexPlayer;
        }
    }


}
