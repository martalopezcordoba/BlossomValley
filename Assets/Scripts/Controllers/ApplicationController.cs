using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameController.Instance.InitGame();
        UIController.Instance.InitUI(); ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
