using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour {
    public enum Score
    {
        AiScore, PlayerScore
    }

    public Text AiScoreTxt, PlayerScoreTxt;
    private int aiScore, playerScore;

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.AiScore)
            AiScoreTxt.text = (++aiScore).ToString();
        else
            PlayerScoreTxt.text = (++playerScore).ToString();
    }

    public void Update()
    {
        if (playerScore >= 5)
        {
            SceneManager.LoadScene("win");
        }

                if (aiScore >= 5)
        {
            SceneManager.LoadScene("lose");
        }
    }

}