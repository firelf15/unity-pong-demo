using UnityEngine;
using TMPro;

public class ManagerDePuntuacion : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText, aiScoreText;
    public Pelota pelota;
    int playerScore, aiScore;

    void Update()
    {
        // Detect scoring (pelota goes off screen)
        if (pelota.transform.position.x > 10f)
        {
            playerScore++;
            playerScoreText.text = playerScore.ToString();
            pelota.ResetPelota();
        }
        else if (pelota.transform.position.x < -10f)
        {
            aiScore++;
            aiScoreText.text = aiScore.ToString();
            pelota.ResetPelota();
        }
    }
}