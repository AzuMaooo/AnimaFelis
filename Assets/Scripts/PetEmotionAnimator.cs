using UnityEngine;

public class PetEmotionAnimator : MonoBehaviour
{
    [Header("References")]
    public PetStateMachine stateMachine;
    public SpriteRenderer petRenderer;

    [Header("Overlays")]
    public GameObject zzzOverlay;
    public GameObject fliesOverlay;

    [Header("Happy Frames (burnthapi, open eye, close eye)")]
    public Sprite[] happyFrames;

    [Header("Hungry Frames (drool, drool2, open eye, close eye)")]
    public Sprite[] hungryFrames;

    [Header("Tired Frames (open eye, close eye, sour)")]
    public Sprite[] tiredFrames;

    [Header("Dirty Frames (open eye, close eye, sour)")]
    public Sprite[] dirtyFrames;

    [Header("Sad Frames (sad1, sad2)")]
    public Sprite[] sadFrames;

    [Header("Combo: Sad + Hungry + Dirty (sad1, drool, sad2, drool2)")]
    public Sprite[] comboFrames;

    [Header("Sleep")]
    public Sprite sleepSprite;

    [Header("Playback")]
    public float framesPerSecond = 2f;

    private PetState lastState = (PetState)(-1);
    private bool wasSleeping = false;
    private bool wasCombo = false;
    private int currentFrame = 0;
    private float timer = 0f;

    void Start()
    {
        UpdateOverlays();
    }

    void Update()
    {
        if (stateMachine == null || petRenderer == null) return;

        bool isSleeping = stateMachine.IsSleeping;

        if (isSleeping != wasSleeping)
        {
            wasSleeping = isSleeping;
            currentFrame = 0;
            timer = 0f;
        }

        if (isSleeping)
        {
            petRenderer.sprite = sleepSprite;
            if (zzzOverlay != null) zzzOverlay.SetActive(true);
            if (fliesOverlay != null) fliesOverlay.SetActive(false);
            return;
        }

        bool isCombo = stateMachine.IsComboSadHungryDirty;

        if (isCombo != wasCombo)
        {
            wasCombo = isCombo;
            currentFrame = 0;
            timer = 0f;
        }

        if (isCombo)
        {
            if (zzzOverlay != null) zzzOverlay.SetActive(false);
            if (fliesOverlay != null) fliesOverlay.SetActive(true);

            if (comboFrames != null && comboFrames.Length > 0)
            {
                timer += Time.deltaTime;
                float comboFrameDuration = 1f / framesPerSecond;
                if (timer >= comboFrameDuration)
                {
                    timer -= comboFrameDuration;
                    currentFrame = (currentFrame + 1) % comboFrames.Length;
                }
                petRenderer.sprite = comboFrames[currentFrame];
            }
            return;
        }

        if (stateMachine.currentState != lastState)
        {
            currentFrame = 0;
            timer = 0f;
            lastState = stateMachine.currentState;
            UpdateOverlays();
        }

        Sprite[] frames = GetFramesForState(stateMachine.currentState);
        if (frames == null || frames.Length == 0) return;

        timer += Time.deltaTime;
        float frameDuration = 1f / framesPerSecond;
        if (timer >= frameDuration)
        {
            timer -= frameDuration;
            currentFrame = (currentFrame + 1) % frames.Length;
        }

        petRenderer.sprite = frames[currentFrame];
    }

    Sprite[] GetFramesForState(PetState state)
    {
        switch (state)
        {
            case PetState.HAPPY: return happyFrames;
            case PetState.HUNGRY: return hungryFrames;
            case PetState.TIRED: return tiredFrames;
            case PetState.NEGLECTED: return dirtyFrames;
            case PetState.SAD: return sadFrames;
            default: return happyFrames;
        }
    }

    void UpdateOverlays()
    {
        if (zzzOverlay != null)
            zzzOverlay.SetActive(stateMachine.currentState == PetState.TIRED);
        if (fliesOverlay != null)
            fliesOverlay.SetActive(stateMachine.currentState == PetState.NEGLECTED);
    }
}