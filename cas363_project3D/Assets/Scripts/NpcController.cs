using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rotateSpeed = 100f;
    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;

    // Implementation of npc movement
    void Update()
    {
        if (!isWandering)
        {
            StartCoroutine(Wander());
        }

        if(isRotatingRight)
        {
            transform.Rotate(transform.up * rotateSpeed * Time.deltaTime);
        }

        if (isRotatingLeft)
        {
            transform.Rotate(-transform.up * rotateSpeed * Time.deltaTime);
        }

        if(isWalking)
        {
            transform.position += -transform.right * moveSpeed * Time.deltaTime;
        }
    }

    IEnumerator Wander()
    {
        int rotatetime = Random.Range(1, 3);
        int rotateWait = Random.Range(1, 4);
        int rotateDirection = Random.Range(1, 2);
        int walkWait = Random.Range(1, 4);
        int walkTime = Random.Range(1, 5);
        
        //steps for npc movement
        isWandering = true;
        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        yield return new WaitForSeconds(walkTime);
        isWalking = false;
        yield return new WaitForSeconds(rotateWait);

        //controls for npc movement
        if (rotateDirection == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotatetime);
            isRotatingRight = false;
        }

        if (rotateDirection == 2)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotatetime);
            isRotatingLeft = false;
        }

        isWandering = false;
    }
}
