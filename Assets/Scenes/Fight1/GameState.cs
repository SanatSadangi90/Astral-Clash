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

    public Vector2 mousePos;


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
        battleDisplay.text = "Colin attacks first!";
        colinSelect.gameObject.SetActive(false);
        brandonSelect.gameObject.SetActive(false);
        foreach (Button attack in colinButtons)
        {
            attack.gameObject.SetActive(true);
        }
    }

    public void colinDropkick()
    {
        battleDisplay.text = "Who will you attack?";
        foreach (Button attack in colinButtons)
        {
            attack.gameObject.SetActive(false);
        }
        
        
    }

    //add 
    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        RaycastHit2D selected = Physics2D.Raycast(mousePos, -Vector2.up);
        if (selected)
        {
            Debug.Log("Hit detected!");
        }
    }
}
