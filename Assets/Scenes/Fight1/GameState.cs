using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public enum BattleState { START, PLAYER1TURN, PLAYER2TURN, ENEMY, WIN, LOSS };

public class GameState : MonoBehaviour
{
    public Person[] protagonists; // Character game objects
    public Person[] antagonists;

    public Button colinSelect;
    public Button brandonSelect;
    public Button[] colinButtons;
    public Button[] brandonButtons;



    public TextMeshProUGUI battleDisplay; // Battle display

    public BattleState state; // Battle Game State


    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        BattleSetup();
        
        
    }
    void BattleSetup()
    {
        battleDisplay.text = "Battle Start!";
        state = BattleState.PLAYER1TURN;
        Player1Turn();
    }

    void Player1Turn()
    {
        battleDisplay.text = "Choose your first attacker:";
        colinSelect.gameObject.SetActive(true);
        brandonSelect.gameObject.SetActive(true);

    }

    public void ColinFirst()
    {
        colinSelect.gameObject.SetActive(false);
        brandonSelect.gameObject.SetActive(false);
        foreach (Button attack in colinButtons)
        {
            attack.gameObject.SetActive(true);
        }
    }

    //add 
    // Update is called once per frame
    void Update()
    {

    }
}
