using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuOperations : MonoBehaviour
{
    //Canvas
    [SerializeField] private Button start_ar_btn;


    void Start()
    {
        Debug.Log("in start!!");

        //Fetch the GameObjects
        start_ar_btn = GameObject.Find("start_ar_btn").GetComponent<Button>();

        //Add listener for when the start ar button is clicked
        start_ar_btn.onClick.AddListener(delegate
        {
            start_ar_btn_clicked(start_ar_btn);
        });

    }

    void start_ar_btn_clicked(Button btn_clicked)
    {
        // Start the scene for the augmented reality functionality 
        SceneManager.LoadScene("ArScene", LoadSceneMode.Single);
    }
}
