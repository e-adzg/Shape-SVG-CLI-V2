class Caretaker
{
    private List<IMemento> _mementos = new List<IMemento>();
    private List<IMemento> _redo = new List<IMemento>();
    private List<IMemento> _allStates = new List<IMemento>();

    private Originator _originator = null;

    public Caretaker(Originator originator)
    {
        this._originator = originator;
    }

    public void resetRedo()
    {
        this._redo.Clear();
    }

    public void Backup()
    {
        //Console.WriteLine("\nCaretaker: Saving Originator's state...");
        this._mementos.Add(this._originator.Save());
        //this._redo.Clear();
    }

    public void BackupIncludingNew()
    {
        this._allStates.Add(this._originator.Save());
    }

    public string Undo()
    {
        if (this._mementos.Count == 0)
        {
            //Console.WriteLine("You cannot undo anymore!");
            return "";
        }

        if (this._redo.Count > 1)
        {
            var latestRedu = this._redo.Last();
            this._redo.Remove(latestRedu);
        }

        var memento = this._mementos.Last();
        this._redo.Add(memento);
        this._mementos.Remove(memento);

        var memento2 = this._mementos.Last();
        this._redo.Add(memento2);
        this._mementos.Remove(memento2);
        //Console.WriteLine("\nCaretaker: Restoring state to: " + memento.GetState());

        try
        {
            this._originator.Restore(memento2);
        }
        catch (Exception)
        {
            this.Undo();
        }
        return memento2.GetState();
    }

    public string Redo()
    {
        var memento = this._redo.Last();
        this._mementos.Add(memento);
        this._redo.Remove(memento);

        var memento2 = this._redo.Last();
        //this._redo.Remove(memento2);

        //this._originator.Restore(memento);

        // Console.WriteLine(memento.GetState());
        // Console.WriteLine(memento2.GetState());
        return memento2.GetState();
    }

    public bool checkIfEqual(string input)
    {
        var memento = this._redo.Last();
        if (memento.GetState() == input)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string checkMementoState()
    {
        var memento = this._mementos.Last();
        return memento.GetState();
    }

    public string checkRedoState()
    {
        var memento = this._redo.Last();
        return memento.GetState();
    }

    public void printUndoList()
    {
        for (int i = 0; i < _mementos.Count; i++)
        {
            Console.WriteLine(_mementos[i].GetState());
        }
    }

    public void printRedoList()
    {
        for (int i = 0; i < _redo.Count; i++)
        {
            Console.WriteLine(_redo[i].GetState());
        }
    }
}