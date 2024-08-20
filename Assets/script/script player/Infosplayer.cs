using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infosplayer : MonoBehaviour
{
    private int score = 0;
    public int lifes = 5;

    private const int MAX_LIFES = 5;

    [SerializeField] private InterfaceController gui;

    private GameController gameScript;

    // Start is called before the first frame update
    void Start()
    {
        lifes = MAX_LIFES;

        gui = GameObject.Find ("Interface").GetComponent<InterfaceController>();

        gui.updateLife(lifes);

        gameScript = GameObject.Find ("GameHolder").GetComponent <GameController>();
    }

    // Update is called once per frame
    public void addScore(int value){

        score += value;
        Debug.Log ("Score actuel du player : " + score);

        gui.updateScore (score);
    }

    public void updateLife(int value)
    {

        lifes += value;
        if (lifes > MAX_LIFES) {
            lifes = MAX_LIFES;
        }
        if (lifes < 0)
        {

            lifes = 0;
        }

        if (lifes <= 0)
        {
            Debug.Log("GAME OVER");
            gameScript.isInGame = false;
        }
        
            gui.updateLife(lifes);
    }
    public void restart()
    {
        lifes = MAX_LIFES;
        score = 0;
        gameScript.isInGame = true;
        gameScript.restartWaves();
        gui.updateLife(lifes);
        gui.updateScore(score);
        gui.hideGameOver();
    }
}
