using UnityEngine;
using UnityEngine.InputSystem;

public class UserInputActionHandler : MonoBehaviour
{
    public static UserInputActionHandler Instance;
    private UserInputAction inputActions;
    private IState state;

    [SerializeField] private GameObject indicator;
    private RectTransform indicatorRect;
    // Should we change state here?

    
    private void Awake()
    {
        // --- Singleton 설정 ---
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        // --- Input Actions 생성 ---
        inputActions = new UserInputAction();

        // --- Indicator RectTransform 캐싱 ---
        if (indicator != null)
            indicatorRect = indicator.GetComponent<RectTransform>();
        else
            Debug.LogError("Indicator reference is missing in the inspector.");
    }


    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Start()
    {
        // ----- User1 -----
        inputActions.User1.Up.performed += _ => HandleUpClicked();
        inputActions.User1.Down.performed += _ => HandleDownClicked();
        inputActions.User1.Left.performed += _ => HandleLeftClicked();
        inputActions.User1.Right.performed += _ => HandleRightClicked();
        inputActions.User1.Confirm.performed += _ => HandleConfirmClicked();
    }

    
    private void HandleRightClicked()
    {
        state.HandleRightClicked();
        ChangePosition();
    }

    private void HandleLeftClicked()
    {
        state.HandleLeftClicked();
        ChangePosition();
    }
    private void HandleUpClicked()
    {
        state.HandleUpClicked();
        ChangePosition();
    }
    private void HandleDownClicked()
    {
        state.HandleDownClicked();
        ChangePosition();
    }

    private void HandleConfirmClicked()
    {
        state.HandleConfirmClicked();
        ChangePosition();
    }
    private void ChangePosition()
    {
        indicatorRect.position= state.ReturnIndicatorPosition();
    }

    public void ChangeToGameState()
    {
        state = GameState.GetInstance();
        state.OnEnter();
        ChangePosition();
    }

    public void ChangeToWaitState()
    {
        state = WaitState.GetInstance();
        state.OnEnter();
        ChangePosition();
    }

    public void ChangeToMenuState()
    {
        state = MenuState.GetInstance();
        state.OnEnter();
        ChangePosition();
    }

    public void ChangeToResultState()
    {
        state = ResultState.GetInstance();
        state.OnEnter();
        ChangePosition();
    }

    public void ChangeToAchievementState()
    {
        state = AchievementState.GetInstance();
        state.OnEnter();
        ChangePosition();
    }

    public void ChangeToChooseModState()
    {
        state = ChooseModState.GetInstance();
        state.OnEnter();
        ChangePosition();
    }
    
}
