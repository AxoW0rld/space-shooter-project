using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    [SerializeField] private Text scoreText,lifeText;

    public Transform LifePanelTransform;
    public GameObject[] lifes = new GameObject[5];

    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find ("scoreText").GetComponent<Text> ();
        //lifeText = GameObject.Find("vieText").GetComponent<Text>();

        int i = 0;
        foreach (Transform child in LifePanelTransform)
        {
            lifes[i] = child.gameObject;
            i++;
        }
        Debug.Log("nbre hearts : " + lifes.Length);

        gameOverPanel.SetActive (false);
    } 

   public void updateScore(int value)
    {

        scoreText.text = "Score : " + value;

    }
    public void updateLife(int value) {
        // = GameObject.Find ("vieText").GetComponent <Text> ();
        //lifeText.text = "Vies : " + value;

        for (int i = 0; i < lifes.Length; i++)
        {
            if (i > (value - 1))
            {
                lifes[i].SetActive(false);
            }
            else
            {
                lifes[i].SetActive(true);
            }
        }
        if (value == 0)
        {
            gameOverPanel.SetActive(true);
        }
    } 
    public void hideGameOver()
    {
        gameOverPanel.SetActive (false);
    }
}
