using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuOperations : MonoBehaviour
{
    //Canvas
    [SerializeField] private Button start_ar_btn;
    [SerializeField] private Button help_btn;
    [SerializeField] private Button quit_btn;


    void Start()
    {
        // set screen orientation to portrait
        Screen.orientation = ScreenOrientation.Portrait;

        //Fetch the GameObjects
        start_ar_btn = GameObject.Find("start_ar_btn").GetComponent<Button>();

        //Add listener for when the start ar button is clicked
        start_ar_btn.onClick.AddListener(delegate
        {
            start_ar_btn_clicked();
        });

        // add listener for when the help button is clicked
        help_btn.onClick.AddListener(delegate
        {
            help_btn_clicked();
        });

        // add listener for when the quit button is clicked
        quit_btn.onClick.AddListener(delegate
        {
            quit_btn_clicked();
        });

    }

    void start_ar_btn_clicked()
    {
        // Start the scene for the augmented reality functionality 
        SceneManager.LoadScene("ArScene", LoadSceneMode.Single);
    }
    void help_btn_clicked()
    {
        // Start the scene for the augmented reality functionality 
        SceneManager.LoadScene("HelpScene", LoadSceneMode.Single);
    }
    void quit_btn_clicked()
    {
        // quit the application
        Application.Quit();
    }
}
