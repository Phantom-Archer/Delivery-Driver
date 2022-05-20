using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed;
    [SerializeField] float moveSpeed;

    bool hasPackage = false;
    bool currentlyCrashed = false;

    public bool GetHasPackage()
    {
        return hasPackage;
    }

    public void SetHasPackage(bool value)
    {
        hasPackage = value;
    }

    public IEnumerator IncreaseSpeed(float speed)
    {
        var originalMoveSpeed = moveSpeed;
        moveSpeed += speed;
        yield return new WaitForSeconds(2.5f);
        moveSpeed = originalMoveSpeed;
    }

    public IEnumerator IncreaseSpeed(float speed, float time)
    {
        var originalMoveSpeed = moveSpeed;
        moveSpeed += speed;
        yield return new WaitForSeconds(time);
        moveSpeed = originalMoveSpeed;
    }

    public IEnumerator DecreaseSpeed(float speed, float time)
    {
        var originalMoveSpeed = moveSpeed;
        moveSpeed -= speed;
        yield return new WaitForSeconds(time);
        moveSpeed = originalMoveSpeed;
    }

    public IEnumerator CrashAndDecreaseSpeed(float speed, float time)
    {
        if (!currentlyCrashed)
        {
            currentlyCrashed = true;
            var originalMoveSpeed = moveSpeed;
            moveSpeed -= speed;
            yield return new WaitForSeconds(time);
            moveSpeed = originalMoveSpeed;
            currentlyCrashed = false;
        }
    }

    void Update()
    {
        Drive();
    }

    void Drive()
    {
        var steerFactor = steerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        var moveFactor = moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        
        transform.Translate(0f, moveFactor, 0f);
        transform.Rotate(0f, 0f, -steerFactor);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(CrashAndDecreaseSpeed(10f, 1f));   
    }
}
