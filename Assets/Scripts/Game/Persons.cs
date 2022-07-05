using System.Collections.Generic;
using UnityEngine;

public class Persons : MonoBehaviour
{
    public List<GameObject> persons = new List<GameObject>();
    public List<GameObject> spawner = new List<GameObject>();
    private GameObject personsGO;
    private score Score;
    ulong moneyP1;

    private Vector2Int map;
    string activePerson;
    void Start()
    {
        map = GameObject.Find("Grid").GetComponent<GraudGaner>().map;
        Score = GameObject.Find("Canvas").GetComponent<score>();

        //Start spawn pos
        spawner[0].transform.position = new Vector3(map.x / 2, 0, -1);
        spawner[1].transform.position = new Vector3(map.x / 2, map.y, -1);



        personsGO = GameObject.Find("Persons");
    }

    // Update is called once per frame
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

                spawnPerson(persons[0], 100);
                break;
            case "archer":
                spawnPerson(persons[1], 100);
                break;
            case "wizard":
                spawnPerson(persons[2], 100);
                break;
            case "rex":
                spawnPerson(persons[3], 100);
                break;
            case "Tank":
                spawnPerson(persons[4], 100);
                break;
        }
    }
    void spawnPerson(GameObject GO, ulong price)
    {
        if (Input.GetMouseButtonUp(0) && Score.moneyP1 >= price)
        {
            Instantiate(GO, spawner[0].transform.position, new Quaternion(0, 0, 0, 0), personsGO.GetComponent<Transform>());
        }
    }


}
