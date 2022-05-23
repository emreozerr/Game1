using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOverScreen : MonoBehaviour
{
    public static int coin_int;
    public Text coin_text;

    private void Start() {
        coin_int = ScoreGenerator.yildizpuani_int;
        coin_text.text = "UR SCORE : "+ coin_int;
    }
    public void ReturnToMainMenu(){
        SceneManager.LoadScene(1);
    }
}
