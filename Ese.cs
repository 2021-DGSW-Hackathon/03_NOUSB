using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ese : MonoBehaviour
{
    public GameObject eseImgae;
    public bool eseOk;
    
    // Start is called before the first frame update
    void Start()
    {
        eseImgae = transform.Find("Ese").gameObject;
        eseImgae.SetActive(false);
        eseOk = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&eseOk==false)
        {
            eseImgae.SetActive(true);
            eseOk = true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && eseOk == true)
        {
            eseImgae.SetActive(false);
            eseOk = false;
        }
    }
}
