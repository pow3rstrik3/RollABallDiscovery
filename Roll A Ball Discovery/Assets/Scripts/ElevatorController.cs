using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    private Vector3 startPosition;
    private bool up = true;

    public int startHeight;
    public int endHeight;
    public int maxSpeed;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update() {
        MoveVertical();
    }

    void MoveVertical()
    {
        var NewPosistion = transform.position;
        if (up == true)
        {
            NewPosistion.y += (maxSpeed * Time.deltaTime);
            transform.position = NewPosistion;
            if (transform.position.y >= endHeight)
            {
                up = false;
            }
        }
        if (up == false) {
            NewPosistion.y -= (maxSpeed * Time.deltaTime);
            transform.position = NewPosistion;
            if (transform.position.y <= startHeight)
            {
                up = true;
            }
        }
    }
}