using UnityEngine;
using TMPro;

public class ManagerDePuntuacion : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText, aiScoreText;
    public Pelota[] pelotas;
    int playerScore, aiScore;

    void Update()
    {
        for (int i = 0; i < pelotas.Length; i++)
        {
            Pelota pelota = pelotas[i];

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
}