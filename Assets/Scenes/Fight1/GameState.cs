using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum BattleState { START, PLAYER, ENEMY, WIN, LOSS };

public class GameState : MonoBehaviour
{
    public int colinHealth = 15;
    public int brandonHealth = 10;
    public int bully1Health = 5;
    public int bully2Health = 5;
    public int brianHealth = 20;

    public GameObject colin;
    public GameObject brandon;
    public GameObject brian;
    public GameObject bully1;
    public GameObject bully2;

    public BattleState state;


    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.PLAYER;

        
    }

    

    //add 
    // Update is called once per frame
    void Update()
    {

    }
}
