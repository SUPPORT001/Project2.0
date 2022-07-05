using System.Collections.Generic;
using UnityEngine;
public class Crip : MonoBehaviour
{
    List<Vector3> cripPath = new List<Vector3>();
    List<Vector3> cripPathReverse = new List<Vector3>();
    
        public string name;
        public float HP;
        public float speed;
        public float ATK;
        public float speedATK;
        public float distant;
        public string typeAttack;
        public int moneyCost;
        public bool side;


    private void Start()
    {
        switch (transform.name )
        {
            case "knight":
                CripStat.Knight knight = new CripStat.Knight();
                name =  knight.name;
                HP = knight.HP;
                speed = knight.speed;
                ATK = knight.ATK;
                speedATK = knight.speedATK;
                distant = knight.distant;
                typeAttack = knight.typeAttack;
                moneyCost = knight.moneyCost;
                break;
            case "archer":
                CripStat.Archer archer = new CripStat.Archer();
                name = archer.name;
                HP = archer.HP;
                speed = archer.speed;
                ATK = archer.ATK;
                speedATK = archer.speedATK;
                distant = archer.distant;
                typeAttack = archer.typeAttack;
                moneyCost = archer.moneyCost;
                break;
            case "wizard":
                CripStat.Wizard wizard = new CripStat.Wizard();
                name = wizard.name;
                HP = wizard.HP;
                speed = wizard.speed;
                ATK = wizard.ATK;
                speedATK = wizard.speedATK;
                distant = wizard.distant;
                typeAttack = wizard.typeAttack;
                moneyCost = wizard.moneyCost;
                break;

            case "rex":
                CripStat.Rex rex = new CripStat.Rex();
                name = rex.name;
                HP = rex.HP;
                speed = rex.speed;
                ATK = rex.ATK;
                speedATK = rex.speedATK;
                distant = rex.distant;
                typeAttack = rex.typeAttack;
                moneyCost = rex.moneyCost;

                break;

            case "tank":
                CripStat.Tank tank = new CripStat.Tank();
                name = tank.name;
                HP = tank.HP;
                speed = tank.speed;
                ATK = tank.ATK;
                speedATK = tank.speedATK;
                distant = tank.distant;
                typeAttack = tank.typeAttack;
                moneyCost = tank.moneyCost;
                break;
        }
       
    }




    void Update()
    {

    }
}
