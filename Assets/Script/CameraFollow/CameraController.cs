using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform dummyTarget;

    private Vector3 defaultPosition;
    private Transform target;

    private void Start()
    {
        defaultPosition = transform.position;
        target = null;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            FocusAtTarget(dummyTarget, 10f);
            Debug.Log("Test");
        }
        if (Input.GetKey(KeyCode.R))
        {
            GoBackToDefault();
        }
    }

    private void FocusAtTarget(Transform targetTransform, float Length)
    {
        target = targetTransform;

        Vector3 targetToCameraDirection = transform.rotation * -Vector3.forward;
        Vector3 targetPosition = targetTransform.position + ((targetToCameraDirection) * Length);

        StartCoroutine(MovePosition(targetPosition, 5));
    }

    private void GoBackToDefault()
    {
        target = null;

        StartCoroutine(MovePosition(defaultPosition, 5));
    }

    private IEnumerator MovePosition(Vector3 target, float time)
    {
        float timer = 0;
        Vector3 Start = transform.position;

        while (timer < time)
        {
            transform.position = Vector3.Lerp(Start, target, Mathf.SmoothStep(0.0f, 1.0f, timer / time));

            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        transform.position = target;
    }


}
