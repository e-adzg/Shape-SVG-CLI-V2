
class CM : IMemento
{
    private string _state;

    public CM(string state)
    {
        this._state = state;
    }

    // The Originator uses this method when restoring its state.
    public string GetState()
    {
        return this._state;
    }
}