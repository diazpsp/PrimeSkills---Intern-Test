using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject tutorialPanel;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        tutorialPanel = GameObject.Find("Tutorial Main Panel");
    }

    void Update()
    {
        if (!tutorialPanel.activeInHierarchy)
        {
            transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
            transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }
        else{

        }
        
    }
}
