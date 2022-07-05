using UnityEngine;


    public class Knight : object
    {
        public string name = "Knight";
        public float HP = 150;
        public float speed = 8;
        public float ATK = 20;
        public float speedATK = 20;
        public float distant = 2;
        public string typeAttack = "Melee";
        public int moneyCost = 25;
        public int side;

    }
    public class Archer
    {
        public string name = "Archer";
        public float HP = 75;
        public float speed = 10;
        public float ATK = 5;
        public float speedATK = 20;
        public float distant = 5;
        public string typeAttack = "Archer";
        public int moneyCost = 35;
        public bool side;

    }
    public class Rex
    {
        public string name = "Rex";
        public float HP = 75;
        public float speed = 13;
        public float ATK = 5;
        public float speedATK = 10;
        public float distant = 2;
        public string typeAttack = "Melee";
        public int moneyCost = 35;
        public bool side;

    }
    public class Wizard
    {
        public string name = "Wizard";
        public float HP = 80;
        public float speed = 8;
        public float ATK = 6;
        public float speedATK = 20;
        public float distant = 5;
        public string typeAttack = "Magik";
        public int moneyCost = 50;
        public bool side;

    }
    public class Tank : object
    {
        public string name = "Tank";
        public float HP = 500;
        public float speed = 6;
        public float ATK = 50;
        public float speedATK = 20;
        public float distant = 2;
        public string typeAttack = "Melee";
        public int moneyCost = 100;
        public bool side;
    }
    //public Knight knight;
    //public Archer archer;
    //public Wizard wizard;
    //public Tank tank;
    //public void Start()

    /*   knight.name = "Knight";
       knight.HP = 150;
       knight.speed = 8;
       knight.ATK = 20;
       knight.speedATK = 20;
       knight.distant = 2;
       knight.typeAttack = "Melee";
       knight.moneyCost = 25;

       archer.name = "Archer";
       archer.HP = 75;
       archer.speed = 10;
       archer.ATK = 5;
       archer.speedATK = 20;
       archer.distant = 5;
       archer.typeAttack = "Archer";
       archer.moneyCost = 35;

       wizard.name = "Wizard";
       wizard.HP = 80;
       wizard.speed = 8;
       wizard.ATK = 6;
       wizard.speedATK = 20;
       wizard.distant = 5;
       wizard.typeAttack = "Magik";
       wizard.moneyCost = 50;

       tank.name = "Tank";
       tank.HP = 500;
       tank.speed = 6;
       tank.ATK = 50;
       tank.speedATK = 20;
       tank.distant = 2;
       tank.typeAttack = "Melee";
       tank.moneyCost = 50;*/