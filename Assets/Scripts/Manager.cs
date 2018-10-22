using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
    enum Turn
    {
        ComputerTurn,
        PlayerTurn
    }
    enum Phases
    {
     DrawPhase,
     MainPhase1,
     BattlePhase,
     MainPhase2,
     EndPhase,
    }
    Phases currentPhase;
    Turn currentTurn;


    int Player1Health = 0;
    int Player2Health = 0;


    public Text currentText = null;

    private Phases CurrentPhase {
        get
        {
            return currentPhase;
        }
        set {
            currentPhase = value;
            UpdateText();
        }
    }

    private Turn CurrentTurn
    {
        get
        {
            return currentTurn;
        }

        set
        {
            currentTurn = value;
            UpdateText();
        }
    }


    // Use this for initialization
    public void Start () {
        Player1Health = 20;
        Player2Health = 20;
        currentPhase = Phases.DrawPhase;
        
    }
    
    public void ChangePhase()
    {
        if (CurrentTurn == Turn.ComputerTurn)
        {
            CurrentTurn = Turn.PlayerTurn;
            CurrentPhase = Phases.DrawPhase;
            return;
        }
        switch (CurrentPhase)
        {
          
            case Phases.DrawPhase:
                CurrentPhase = Phases.MainPhase1;
                break;
            case Phases.MainPhase1:
                CurrentPhase = Phases.BattlePhase;
                break;
            case Phases.BattlePhase:
                CurrentPhase = Phases.MainPhase2;
                break;
            case Phases.MainPhase2:
                CurrentPhase = Phases.EndPhase;
                break;
            case Phases.EndPhase:
                CurrentPhase = Phases.DrawPhase;
                CurrentTurn = CurrentTurn == Turn.ComputerTurn ? Turn.PlayerTurn : Turn.ComputerTurn;
                break;
        }
        
    }
    public void UpdateText()
    {
        if (CurrentTurn == Turn.ComputerTurn)
        {
            currentText.text = "Not your turn";
        } else
        {
            currentText.text = CurrentPhase.ToString();
        }
    }
    public void ChangeText(string word)
    {
        currentText.text = word;
    }
}
