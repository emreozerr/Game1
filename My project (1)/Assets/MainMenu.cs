using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void QuitGame(){
        Debug.Log( "Oyundan çıktın!");
        Application.Quit();
    }
    
    public void GameSettings(){
         Debug.Log( "Degistir bakalım bir seyler!");
    }

    public void ReturnToMainMenu(){
        SceneManager.LoadScene(1);
    }
    

}
