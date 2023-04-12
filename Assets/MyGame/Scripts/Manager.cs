using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private Image computer, player;
    public Text winner;
    public Text score;
    public GameObject Schere;
    public GameObject Stein;
    public GameObject Papier;

    public GameObject Schere2;
    public GameObject Stein2;
    public GameObject Papier2;

    public int playerScore;
    public int computerScore;
    private int rnd;
    private int rnd2;
    private int runde;
    public void DeleteSore()
    {
        playerScore = 0;
        computerScore = 0;
        runde = 0;
        Schere.SetActive(false);
        Stein.SetActive(false);
        Papier.SetActive(false);

        Schere2.SetActive(false);
        Stein2.SetActive(false);
        Papier2.SetActive(false);
        winner.text = "";

    }
    public void PlayGame()
    {
        Debug.Log("Gedrückt");
        runde++;


        rnd = Random.Range(0, 3);
        if (rnd == 0)
        {
            Schere.SetActive(true);
            Stein.SetActive(false);
            Papier.SetActive(false);
           
        }
        if (rnd == 1)
        {
            Schere.SetActive(false);
            Stein.SetActive(true);
            Papier.SetActive(false);
            
        }
        if (rnd == 2)
        {
            Schere.SetActive(false);
            Stein.SetActive(false);
            Papier.SetActive(true);
            
        }


        rnd2 = Random.Range(0, 3);
        if (rnd2 == 0)
        {
            Schere2.SetActive(true);
            Stein2.SetActive(false);
            Papier2.SetActive(false);
            
        }
        if (rnd2 == 1)
        {
            Schere2.SetActive(false);
            Stein2.SetActive(true);
            Papier2.SetActive(false);
            
        }
        if (rnd2 == 2)
        {
            Schere2.SetActive(false);
            Stein2.SetActive(false);
            Papier2.SetActive(true);
            


        }
        if (rnd == 0 && rnd2 == 2 || rnd == 2 && rnd2 == 1 || rnd == 1 && rnd2 == 0)
        {
            playerScore = playerScore + 1;
        }
        if (rnd2 == 0 && rnd == 2 || rnd2 == 2 && rnd == 1 || rnd2 == 1 && rnd == 0)
        {
            computerScore = computerScore + 1;
        }
        winner.text = "";
    }
    void Start()
    {
        Schere.SetActive(false);
        Stein.SetActive(false);
        Papier.SetActive(false);

        Schere2.SetActive(false);
        Stein2.SetActive(false);
        Papier2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Player:" + playerScore + "Computer:" + computerScore;
        if (runde == 5)
        {
            if (playerScore > computerScore)
            {
                Debug.Log("Playerwins");
                winner.text = "Player";
            }
            if (playerScore < computerScore)
            {
                Debug.Log("Computerwins");
                winner.text = "Computer";
            }
            if (playerScore == computerScore)
            {
                Debug.Log("No one wins");
                winner.text = "Niemand, Unentschieden";
            }
            runde = 0;
        }
    }
}