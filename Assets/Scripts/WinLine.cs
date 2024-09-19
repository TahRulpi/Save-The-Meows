using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Add this to handle scene loading

public class WinLine : MonoBehaviour
{
    public AudioSource winAudio;
    public TextMeshProUGUI winText;
    private bool playerHasWon = false; // Track if the player has won

    private void Start()
    {
        winText.gameObject.SetActive(false); // Hide the win text at start
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            winAudio.Play();
            winText.gameObject.SetActive(true); // Show win text
            playerHasWon = true; // Player has collided, set to true
        }
    }



    private void Update()
    {
        if (playerHasWon && Input.GetMouseButtonDown(0))
        {
            int sceneCount = SceneManager.sceneCountInBuildSettings; // Get scene count

            // Check if the desired scene index is within bounds
            int targetSceneIndex = SceneManager.GetActiveScene().buildIndex + 3;
            if (targetSceneIndex < sceneCount)
            {
                SceneManager.LoadScene(targetSceneIndex);
            }
            else
            {
                Debug.Log("Target scene index is out of bounds! Consider a different approach.");
            }
        }
    }

}
