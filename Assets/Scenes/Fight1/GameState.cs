using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum BattleState { START, PLAYER, ENEMY, WIN, LOSS };

public class GameState : MonoBehaviour
{
    public GameObject colin;    // Character game objects
    public GameObject brandon;
    public GameObject brian;
    public GameObject bully1;
    public GameObject bully2;

    public Text battleDisplay; // Battle display

    public BattleState state; // Battle Game State


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
