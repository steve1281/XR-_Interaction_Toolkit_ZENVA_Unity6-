using UnityEngine;

public class Faucet : MonoBehaviour
{
    private bool isOn;

    [SerializeField]
    private Transform tapObject;
    [SerializeField]
    private Vector3 offRotation;
    [SerializeField]
    private Vector3 onRotation;
    [SerializeField]
    private ParticleSystem waterParticle;

    private void Start()
    {
        TurnOff();
    }
    public void Toggle()
    {
        if (isOn)
        {
            TurnOff();
        }
        else
        {
            TurnOn();
        }
    }
    void TurnOn()
    {
        isOn = true;
        waterParticle.Play();
        tapObject.localEulerAngles = onRotation;
    }
    void TurnOff()
    {
        isOn = false;
        waterParticle.Stop();
        tapObject.localEulerAngles = offRotation;
    }
}
