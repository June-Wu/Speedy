using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;


    // Update is called once per frame
    void Update()
    {
        if (player.position.y >= 1) {
            scoreText.text = ((player.position.z + 245) / 10).ToString("0");
        }
    }
}
