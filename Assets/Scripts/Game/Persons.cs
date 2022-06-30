using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persons : MonoBehaviour
{
    List <GameObject> persons = new List<GameObject>();
    GameObject personsGO;
    score Score;
    string activeTower;
    void Start()
    {
        

        personsGO = GameObject.Find("persons");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shooseTowerStr(string str) //Для кнопок
    {
        activeTower = str;
    }
    GameObject chooseTower()
    {

        switch (activeTower)
        {
            case "knight":

                spawnPerson(persons[0], 100);
                break;
            case "archer":
                spawnPerson(persons[1], 100);
                break;
        }
        var asd = this.gameObject;
        return asd;
    }
    void spawnPerson(GameObject GO, ulong price)
    {
        if (Input.GetMouseButtonUp(0) && Score.moneyP1 >= price)
        {
            Instantiate(GO, GetComponentInParent<Player>().mousePosTile(), new Quaternion(0, 0, 0, 0), personsGO.GetComponent<Transform>()); //Сделать проверку на препятствие

        }
       

    }
}
