using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
    bool DrawPhase = false;
    bool MainPhase1 = false;
    bool BattlePhase = false;
    bool MainPhase2 = false;
    bool EndPhase = false;
    string currentPhase;

    public Text currentText = null;


	// Use this for initialization
	void Awake () {
        
        DrawPhase = true;
        currentPhase = "DrawPhase";
        
    }

    private void Start()
    {
        ChangeText(currentPhase);
    }
    public void ChangePhase()
    {
        
        ChangeText(currentPhase);
        if (DrawPhase && !MainPhase1 && !BattlePhase && !MainPhase2 && !EndPhase)
        {
            DrawPhase = false;
            MainPhase1 = true;
            currentPhase = "MainPhase1";
            
        }
        else if (!DrawPhase && MainPhase1 && !BattlePhase && !MainPhase2 && !EndPhase)
        {
            MainPhase1 = false;
            BattlePhase = true;
            currentPhase = "BattlePhase";
            
        }
        else if (!DrawPhase && !MainPhase1 && BattlePhase && !MainPhase2 && !EndPhase)
        {
            BattlePhase = false;
            MainPhase2 = true;
            currentPhase = "MainPhase2";
            
        }
        else if (!DrawPhase && !MainPhase1 && !BattlePhase && MainPhase2 && !EndPhase)
        {
            MainPhase2 = false;
            EndPhase = true;
            currentPhase = "EndPhase";
            
        }
        else if(!DrawPhase && !MainPhase1 && !BattlePhase && !MainPhase2 && EndPhase)
        {
            EndPhase = false;
            currentPhase = "Not your turn!";
        }
        else
        {
            DrawPhase = true;
            currentPhase = "DrawPhase";
        }
        
    }
    public void ChangeText(string word)
    {
        currentText.text = word;
    }
}
