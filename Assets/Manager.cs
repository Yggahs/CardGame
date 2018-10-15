using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    bool DrawPhase = false;
    bool MainPhase1 = false;
    bool BattlePhase = false;
    bool MainPhase2 = false;
    bool EndPhase = false;
    string currentPhase;

	// Use this for initialization
	void Start () {
        
        DrawPhase = true;
        Debug.Log("Draw a card");
        DrawPhase = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(!DrawPhase && !BattlePhase && !MainPhase2 && !EndPhase)
        {
            MainPhase1 = true;
            currentPhase = "MainPhase1";
        }
        if (!DrawPhase && !MainPhase1 && !MainPhase2 && !EndPhase)
        {
            BattlePhase = true;
            currentPhase = "BattlePhase";
        }
        if (!DrawPhase && !MainPhase1 && !BattlePhase && !EndPhase)
        {
            MainPhase2 = true;
            currentPhase = "MainPhase2";
        }
        if (!DrawPhase && !MainPhase1 && !BattlePhase && !MainPhase2)
        {
            EndPhase = true;
            currentPhase = "EndPhase";
        }

        Debug.Log(currentPhase);
    }
}
