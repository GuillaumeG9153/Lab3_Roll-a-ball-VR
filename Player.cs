using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;
using TMPro;


public class Player : MonoBehaviour
{
    public float speed = 0;

    public TextMeshProUGUI countText;

    public GameObject winTextObject;

    private int count;

    private Rigidbody rb;

    public bool isMobileBuild = true;

    public TextMeshProUGUI accText;



    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);

        //if (isMobileBuild)
        //{

           //enable reading sensor values
           //InputSystem.EnableDevice(UnityEngine.InputSystem.Accelerometer.current);
       // }
    }

    
    

 

    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickups"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Count :" + count.ToString();
        if (count >= 9)
        {
            winTextObject.SetActive(true);
        }
    }
}
