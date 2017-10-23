using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private int score;
    public Score scoreManager;
    public Score scoreManager1;

    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
            if (scoreManager != null)
            {
                scoreManager.UpdateScore();
                scoreManager1.UpdateScore();
            }
        }
    }
}
