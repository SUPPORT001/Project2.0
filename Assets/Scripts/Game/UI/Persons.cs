using System.Collections.Generic;
using UnityEngine;

public class Persons : MonoBehaviour
{
    public List<GameObject> persons = new List<GameObject>();
    public List<GameObject> spawner = new List<GameObject>();
    private GameObject personsGO;

    string activePerson;

    public List<GameObject> BlueCrips = new List<GameObject>();
    public List<GameObject> RedCrips = new List<GameObject>();

    void Start()
    {
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
        if(activePerson == "knight")
        {
            Crip crip = new Crip(
                    ConfigCrip.knight_name,
                    ConfigCrip.knight_HP,
                    ConfigCrip.knight_speed,
                    ConfigCrip.knight_ATK,
                    ConfigCrip.knight_speedATK,
                    ConfigCrip.knight_distant,
                    ConfigCrip.knight_typeAttack,
                    ConfigCrip.knight_moneyCost);
            spawnPerson(persons[0], crip.moneyCost, crip);
        }
        else if(activePerson == "archer")
        {
            Crip crip = new Crip(
                    ConfigCrip.archer_name,
                    ConfigCrip.archer_HP,
                    ConfigCrip.archer_speed,
                    ConfigCrip.archer_ATK,
                    ConfigCrip.archer_speedATK,
                    ConfigCrip.archer_distant,
                    ConfigCrip.archer_typeAttack,
                    ConfigCrip.archer_moneyCost);
            spawnPerson(persons[1], crip.moneyCost, crip);
        }
        else if(activePerson == "wizard")
        {
            Crip crip = new Crip(
                    ConfigCrip.wizard_name,
                    ConfigCrip.wizard_HP,
                    ConfigCrip.wizard_speed,
                    ConfigCrip.wizard_ATK,
                    ConfigCrip.wizard_speedATK,
                    ConfigCrip.wizard_distant,
                    ConfigCrip.wizard_typeAttack,
                    ConfigCrip.wizard_moneyCost);
            spawnPerson(persons[2], crip.moneyCost, crip);
        }
        else if(activePerson == "rex")
        {
            Crip crip = new Crip(
                    ConfigCrip.rex_name,
                    ConfigCrip.rex_HP,
                    ConfigCrip.rex_speed,
                    ConfigCrip.rex_ATK,
                    ConfigCrip.rex_speedATK,
                    ConfigCrip.rex_distant,
                    ConfigCrip.rex_typeAttack,
                    ConfigCrip.rex_moneyCost);
            spawnPerson(persons[3], crip.moneyCost, crip);
        }
        else if(activePerson == "Tank")
        {
            Crip crip = new Crip(
                    ConfigCrip.tank_name,
                    ConfigCrip.tank_HP,
                    ConfigCrip.tank_speed,
                    ConfigCrip.tank_ATK,
                    ConfigCrip.tank_speedATK,
                    ConfigCrip.tank_distant,
                    ConfigCrip.tank_typeAttack,
                    ConfigCrip.tank_moneyCost);
            spawnPerson(persons[4], crip.moneyCost, crip);
        }
    }
    void spawnPerson(GameObject GO, int price, Crip crip)
    {
        if (Input.GetMouseButtonUp(0) && score.moneyP1 >= price)
        {
            string GOname = GO.name;
            GameObject GO2;
            if (Config.indexPlayer == 0 && score.moneyP1 >= price)
            {
                GO2 = Instantiate(GO, spawner[0].transform.position, Quaternion.identity, personsGO.GetComponent<Transform>());
                GO2.tag = "BlueCrip";
                BlueCrips.Add(GO2);
                GO2.GetComponent<Crip>().Gett(crip);
            }
            else
            {
                GO2 = Instantiate(GO, spawner[1].transform.position, Quaternion.identity, personsGO.GetComponent<Transform>());
                GO2.GetComponent<SpriteRenderer>().flipX = true;
                GO2.tag = "RedCrip";
                RedCrips.Add(GO2);
                GO2.GetComponent<Crip>().Gett(crip);
            }
        }
    }
}
