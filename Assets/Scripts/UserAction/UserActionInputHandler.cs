using UnityEngine;
using UnityEngine.InputSystem;

public class UserInputActionHandler : MonoBehaviour
{
    private UserInputAction inputActions;
    private IState state;

    [SerializeField] private GameObject indicator;
    private RectTransform indicatorRect;
    // Should we change state here?
    private void ChangeToGameState() => state = new GameState();
    private void ChangeToWaitState() => state = new WaitState();
    private void ChangeToMenuState()=> state = new MenuState();
    private void ChangeToResultState()=> state = new ResultState();
    private void ChangeToAchievementState()=> state = new AchievementState();
    
    
    private void Awake()
    {
        inputActions = new UserInputAction();
        indicatorRect =  indicator.GetComponent<RectTransform>();
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


}
