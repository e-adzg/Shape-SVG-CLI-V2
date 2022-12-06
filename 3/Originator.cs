class Originator
{
    private string _state;

    public Originator(string state)
    {
        this._state = state;
    }

    public void DoSomething(string input)
    {
        this._state = input;
        //Console.WriteLine($"Originator: and my state has changed to: {_state}");
    }

    public IMemento Save()
    {
        //Console.WriteLine(this._state);
        return new CM(this._state);
    }

    public void Restore(IMemento memento)
    {
        if (!(memento is CM))
        {
            throw new Exception("Unknown memento class " + memento.ToString());
        }

        this._state = memento.GetState();
        //Console.Write($"Originator: My state has changed to: {_state}");
    }
}