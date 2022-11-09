using UnityEngine;

public class StateMachine : MonoBehaviour
{
    ControllerState currentState;
    [SerializeField] PlayerController playerController;

private IdleState idleState;
    public void Start()
    {
        currentState = GetInitialState();
        
        if (currentState != null) 
        {
            currentState.Enter();
        }
    }
    public void Update()
    {
        currentState.Update();
    }
    public void FixedUpdate()
    {
        currentState.FixedUpdate();
    }
    public void ChangeState(ControllerState newState)
    {
        currentState.Exit();

        currentState = newState;
        currentState.Enter();
    }
    //// ???? что это? зачем? почему протектед? зачем виртуал? 
    ////почитай о модификаторах доступа. какие зачем используются
    /// почитай о переопределение методов
    protected virtual ControllerState GetInitialState() 
    {
        return null;
    }
    
    
    // тебе нужно инициализировать состояния 
    private void InitStates () {
     
    }
}

