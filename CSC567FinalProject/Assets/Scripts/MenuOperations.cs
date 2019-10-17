using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOperations : MonoBehaviour
{
    //Canvas
    [SerializeField] private Dropdown class_dropDown;
    [SerializeField] private Dropdown module_dropDown;
    [SerializeField] private Button start_ar_btn;

    string class_selected = "";
    string module_selected = "";
    int class_index = 0;
    int module_index = 0;


    void Start()
    {
        Debug.Log("in start!!");

        //Fetch the GameObjects
        class_dropDown = GameObject.Find("class_dropdown").GetComponent<Dropdown>();
        module_dropDown = GameObject.Find("module_dropdown").GetComponent<Dropdown>();
        start_ar_btn = GameObject.Find("start_ar_btn").GetComponent<Button>();

        //Add listener for when the value of the class dropdown changes, to take action
        class_dropDown.onValueChanged.AddListener(delegate {
            class_dd_value_changed(class_dropDown);
        });

        //Add listener for when the value of the module dropdown changes, to take action
        module_dropDown.onValueChanged.AddListener(delegate {
            module_dd_value_changed(module_dropDown);
        });
    }

    void class_dd_value_changed(Dropdown change)
    {
        //Keep the current index of the Dropdown in a variable
        class_index = change.value;

        // Get the new value of the class selected
        class_selected = change.options[class_index].text;

        Debug.Log("value changed!");

        // now that we have a class selected, we can enable the module dropdown
        module_dropDown.interactable = true;
    }

    void module_dd_value_changed(Dropdown change)
    {
        //Keep the current index of the Dropdown in a variable
        module_index = change.value;

        // Get the new value of the class selected
        module_selected = change.options[module_index].text;

        Debug.Log("value changed!");

        // now that we have a class selected, we can enable the module dropdown
        start_ar_btn.interactable = true;
    }
}
