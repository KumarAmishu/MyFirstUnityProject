using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyFirstscript : MonoBehaviour
{
    // Start is called before the first frame update

    public Button button;

    public string newscene;
    private void Start()
    {
        button.onClick.AddListener(OnButtonClick) ;
    }
    
    private void OnButtonClick()
    {
     
       Debug.Log("Button pressed"); 
       SceneManager.LoadScene(newscene);

    }

    // Update is called once per frame
    
    
}