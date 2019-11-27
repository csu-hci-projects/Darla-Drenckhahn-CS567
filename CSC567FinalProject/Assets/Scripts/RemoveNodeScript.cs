using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RemoveNodeScript : MonoBehaviour
{
    [SerializeField] private Button back_btn;

    // Start is called before the first frame update
    void Start()
    {
        // Set orientation to portrait
        Screen.orientation = ScreenOrientation.LandscapeRight;

        // get game objects
        back_btn = GameObject.Find("back_btn").GetComponent<Button>();

        // add listener for when the back button gets clicked
        back_btn.onClick.AddListener(delegate
        {
            back_btn_clicked(back_btn);
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {

            if (Input.GetKeyUp(KeyCode.Escape))
            {

                //quit application on return button

                Application.Quit();

                return;

            }
        }
    }

    void back_btn_clicked(Button btn_clicked)
    {
        // start scene to go back to main menu
        SceneManager.LoadScene("ArScene", LoadSceneMode.Single);
    }
}
