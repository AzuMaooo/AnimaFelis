using UnityEngine;

public enum PetState { HAPPY, SAD, HUNGRY, TIRED, NEGLECTED }

public class PetStateMachine : MonoBehaviour
{
    [Header("Stats (0-100)")]
    public float hunger = 40f;
    public float happiness = 40f;
    public float energy = 40f;

    [Header("State")]
    public PetState currentState = PetState.SAD;

    [Header("Drain Rates (per second)")]
    public float hungerDrain = 1f;
    public float happinessDrain = 0.5f;
    public float energyDrain = 0.8f;

    void Update()
    {
        DrainStats();
        UpdateState();
    }

    void DrainStats()
    {
        hunger = Mathf.Clamp(hunger - hungerDrain * Time.deltaTime, 0, 100);
        happiness = Mathf.Clamp(happiness - happinessDrain * Time.deltaTime, 0, 100);
        energy = Mathf.Clamp(energy - energyDrain * Time.deltaTime, 0, 100);
    }

    void UpdateState()
    {
        if (hunger < 30f) currentState = PetState.HUNGRY;
        else if (energy < 30f) currentState = PetState.TIRED;
        else if (happiness < 30f) currentState = PetState.SAD;
        else if (hunger < 10f || happiness < 10f || energy < 10f) currentState = PetState.NEGLECTED;
        else currentState = PetState.HAPPY;
    }

    public void Feed() => hunger = Mathf.Clamp(hunger + 30f, 0, 100);
    public void Play() => happiness = Mathf.Clamp(happiness + 25f, 0, 100);
    public void Rest() => energy = Mathf.Clamp(energy + 35f, 0, 100);
    public void Clean() => happiness = Mathf.Clamp(happiness + 15f, 0, 100);
}