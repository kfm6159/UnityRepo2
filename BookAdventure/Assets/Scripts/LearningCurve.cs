using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //Variables live up here, under the Class & before the Methods
    //I'm assuming you could technically put them anywhere as long
    //as they're within the Class, but it's cleaner & best practice
    //to keep them up top & together
        private int CurrentAge = 30;
        public int AddedAge = 1;
        public int CurrentGold = 32;
        public bool PureOfHeart = true;
        public bool HasSecretIncantation = false;
        public string RareItem = "Relic Stone";
        public string CharacterAction = "Attack";
        public int DiceRoll = 7;
        public int PlayerLives = 3;
        public Transform CamTransform;
        public GameObject DirectionLight;
        public Transform LightTransform;

        public float Pi = 3.14f;
        public string FirstName = "Kylie";
        public bool IsStudent = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);

        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        Character hero = new Character();
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
        
        Character villain= hero;
        villain.name = "Dracula";

        Character heroine = new Character("Autumn");
        Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name, heroine.exp);

        hero.PrintStatsInfo();
        villain.PrintStatsInfo();

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();

        HealthStatus();
        FindPartyMember();
        RollDice();
        PrintCharacterAction();
        OpenTreasureChamber();
        Thievery();
        int CharacterLevel = 32;
        GenerateCharacter("Spike", CharacterLevel);
        int NextSkillLevel = GenerateCharacter("Spike", CharacterLevel);
        Debug.Log(NextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", CharacterLevel));
        
    }

    void Update()
    {

    }

    public void HealthStatus()
    {
        while(PlayerLives > 0)
        {
            Debug.Log("Still breathing!");
            PlayerLives--;
        }

        Debug.Log("Player KO'd...");
    }

    // adding comments
    // just like the book
    // keeping it consistent
    // just to make it visually simple
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    //This is a public method (indicated by "public") with
    //a numeric return type (indicated by "int").
    public int GenerateCharacter(string name, int level)
    {
        //Debug.LogFormat("Character: {0} - Level: {1}", name, level);

        return level += 5;
    }
    
    //This is a public method (indicated by "public") with
    //no return value (indicated by "void").
    public void Thievery()
    {
        if(CurrentGold > 50)
        {
            Debug.Log("You're rolling in it!");
        }
        
        else if (CurrentGold < 15)
        {
            Debug.Log("Not much there to steal...");
        }

        else
        {
            Debug.Log("Looks like your purse is in the sweet spot.");
        }
    }

    public void OpenTreasureChamber()
    {
        if(PureOfHeart && RareItem == "Relic Stone")
        {
            if(!HasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
            }
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
        }
    }

    public void PrintCharacterAction()
    {
        switch(CharacterAction)
        {
            case "Heal":
            Debug.Log("Potion sent.");
            break;
            case "Attack":
            Debug.Log("To arms!");
            break;
            default:
            Debug.Log("Shields up.");
            break;
        }
    }

    public void RollDice()
    {
        switch(DiceRoll)
        {
            case 7:
            case 15:
                Debug.Log("Decent hit, some damage.");
                break;
            case 20:
                Debug.Log("Critical hit!");
                break;
            default:
                Debug.Log("Critical miss! Oof...");
                break;
        }
    }

    public void FindPartyMember()
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };

        foreach(string partyMember in QuestPartyMembers)
        {
            Debug.LogFormat("{0} - Here!", partyMember);
        }

        int listLength = QuestPartyMembers.Count;

        // Add, insert, and remove elements to practice with lists
        QuestPartyMembers.Add("Craven the Necromancer");
        QuestPartyMembers.Insert(1, "Tanis the Thief");
        QuestPartyMembers.RemoveAt(0);
        // QuestPartyMembers.Remove("Grim the Barbarian");

        Debug.LogFormat("Party Members: {0}", listLength);

        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);

            if (QuestPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }
    }
}
