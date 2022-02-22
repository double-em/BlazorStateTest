using Fluxor;

namespace BlazorStateTest.Store;

public static class Reducers
{
    [ReducerMethod]
    public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
        new (state.ClickCount + 1);
    
    // To remove unused parameter warning, instead:
    // [ReducerMethod(typeof(IncrementCounterAction))]
    // public static CounterState ReduceIncrementCounterAction(CounterState state) =>
    //     new CounterState(clickCount: state.ClickCount + 1);
}