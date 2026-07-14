using UnityEngine;
using UnityEngine.UI;

public enum PetState { HAPPY, SAD, HUNGRY, TIRED, NEGLECTED }

public class PetStateMachine : MonoBehaviour
{
    [Header("Stats (0-100)")]
    public float hunger = 40f;
    public float happiness = 40f;
    public float energy = 40f;
    public float cleanliness = 40f;

    [Header("State")]
    public PetState currentState = PetState.SAD;

    [Header("Drain Rates (per second)")]
    public float hungerDrain = 1f;
    public float happinessDrain = 0.5f;
    public float energyDrain = 0.8f;
    public float cleanlinessDrain = 0.3f;

    [Header("Sleep")]
    private bool isSleeping = false;
    public bool IsSleeping => isSleeping;
    public float restFillRate = 20f;

    [Header("UI Bars")]
    public Slider hungerBar;
    public Slider happinessBar;
    public Slider energyBar;
    public Slider cleanlinessBar;

    [Header("Buttons")]
    public UnityEngine.UI.Button feedButton;
    public UnityEngine.UI.Button playButton;
    public UnityEngine.UI.Button restButton;
    public UnityEngine.UI.Button cleanButton;
    public UnityEngine.UI.Image feedLockIcon;
    public UnityEngine.UI.Image playLockIcon;
    public UnityEngine.UI.Image cleanLockIcon;

    void Start()
    {
        if (hungerBar != null) { hungerBar.minValue = 0; hungerBar.maxValue = 100; }
        if (happinessBar != null) { happinessBar.minValue = 0; happinessBar.maxValue = 100; }
        if (energyBar != null) { energyBar.minValue = 0; energyBar.maxValue = 100; }
        if (cleanlinessBar != null) { cleanlinessBar.minValue = 0; cleanlinessBar.maxValue = 100; }
        UpdateButtonStates();
    }

    void Update()
    {
        DrainStats();
        UpdateState();
        if (isSleeping)
        {
            if (energy < 100f)
                energy = Mathf.Clamp(energy + restFillRate * Time.deltaTime, 0, 100);
            else
            {
                isSleeping = false;
                UpdateButtonStates();
            }
        }
        UpdateUI();
    }

    void DrainStats()
    {
        hunger = Mathf.Clamp(hunger - hungerDrain * Time.deltaTime, 0, 100);
        happiness = Mathf.Clamp(happiness - happinessDrain * Time.deltaTime, 0, 100);
        energy = Mathf.Clamp(energy - energyDrain * Time.deltaTime, 0, 100);
        cleanliness = Mathf.Clamp(cleanliness - cleanlinessDrain * Time.deltaTime, 0, 100);
    }

    void UpdateState()
    {
        if (hunger < 30f) currentState = PetState.HUNGRY;
        else if (energy < 30f) currentState = PetState.TIRED;
        else if (happiness < 30f) currentState = PetState.SAD;
        else if (cleanliness < 30f) currentState = PetState.NEGLECTED;
        else currentState = PetState.HAPPY;
    }

    void UpdateUI()
    {
        if (hungerBar != null) hungerBar.value = hunger;
        if (happinessBar != null) happinessBar.value = happiness;
        if (energyBar != null) energyBar.value = energy;
        if (cleanlinessBar != null) cleanlinessBar.value = cleanliness;
    }

    public void Feed()
    {
        if (hunger >= 80f)
            happiness = Mathf.Clamp(happiness - 10f, 0, 100);
        else
            hunger = Mathf.Clamp(hunger + 30f, 0, 100);
    }
    public void Play()
    {
        happiness = Mathf.Clamp(happiness + 25f, 0, 100);
        hunger = Mathf.Clamp(hunger - 15f, 0, 100);
        cleanliness = Mathf.Clamp(cleanliness - 15f, 0, 100);
    }

    public bool IsComboSadHungryDirty => hunger < 30f && cleanliness < 30f && happiness < 30f;
    public void Rest()
    {
        isSleeping = !isSleeping;
        UpdateButtonStates();
    }

    void UpdateButtonStates()
    {
        feedButton.interactable = !isSleeping;
        playButton.interactable = !isSleeping;
        cleanButton.interactable = !isSleeping;

        feedLockIcon.gameObject.SetActive(isSleeping);
        playLockIcon.gameObject.SetActive(isSleeping);
        cleanLockIcon.gameObject.SetActive(isSleeping);
    }

    public void Clean() => cleanliness = Mathf.Clamp(cleanliness + 30f, 0, 100);
}