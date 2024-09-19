using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class GameManager : MonoBehaviour
{
    public static int score = 0; // Static score to access from other scripts
    public TextMeshProUGUI scoreText; // TextMeshPro UI to show score

    private void Update()
    {
        scoreText.text = "Your Points: " + score.ToString(); // Update the score text
    }

    public static void AddScore(int points)
    {
        score += points; // Increase score by the given points
    }
}
