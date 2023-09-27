using System.Collections;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    protected float timeMax = 10f;
    public float TimeMax => timeMax;
    protected float countdownValue = 10f;
    public float CountdownValue => countdownValue;

    private bool isCountingDown = false;

    protected void FixedUpdate()
    {
        if (isCountingDown)
        {
            if (countdownValue < 0.2f)
            {
                ResetCountdown();
            }
        }
    }

    IEnumerator Countdown()
    {
        while (countdownValue > 0.1f)
        {
            yield return new WaitForSeconds(0.1f);
            countdownValue= Mathf.Round((countdownValue - 0.1f) * 10f ) / 10f;
        }
    }

    public void StartCountdown()
    {
        isCountingDown = true;
        StartCoroutine(Countdown());
    }

    void ResetCountdown()
    {
        isCountingDown = false;
        countdownValue = 10f;
    }
}
