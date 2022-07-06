using System.Collections.Generic;
using UnityEngine;

public class Crip : MonoBehaviour
{
    public string name;
    public float HP;
    public float speed;
    public float ATK;
    public float speedATK;
    public float distant;
    public string typeAttack;
    public int moneyCost;

    //Функция для передачи переменных в другие скрипты
    public Crip(string name, float hP, float speed, float aTK, float speedATK, float distant, string typeAttack, int moneyCost) 
    {
        this.name = name;
        this.HP = hP;
        this.speed = speed;
        this.ATK = aTK;
        this.speedATK = speedATK;
        this.distant = distant;
        this.typeAttack = typeAttack;
        this.moneyCost = moneyCost;
    }
 
    public void Gett(Crip crip)
    {
        this.name = crip.name;
        this.HP = crip.HP;
        this.speed = crip.speed;
        this.ATK = crip.ATK;
        this.speedATK = crip.speedATK;
        this.distant = crip.distant;
        this.typeAttack = crip.typeAttack;
        this.moneyCost = crip.moneyCost;
    }
}