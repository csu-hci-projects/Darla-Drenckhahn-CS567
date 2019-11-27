using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HelpScript : MonoBehaviour
{
    [SerializeField] private Button back_btn;

    // Start is called before the first frame update
    void Start()
    {
        // Set orientation to portrait
        Screen.orientation = ScreenOrientation.Portrait;

        // get game objects
        back_btn = GameObject.Find("backButton").GetComponent<Button>();

        // add listener for when the back button gets clicked
        back_btn.onClick.AddListener(delegate
        {
            back_btn_clicked();
        });
    }

    void back_btn_clicked()
    {
        // start scene to go back to main menu
        SceneManager.LoadScene("MainMenuScene", LoadSceneMode.Single);
    }
}
