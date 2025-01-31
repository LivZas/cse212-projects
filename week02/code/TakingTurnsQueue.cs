// Summary of the errors and test results
// Error 1: TestTakingTurnsQueue_Forever Negative: The person with negative turns didn't stay in the queue.
// Error 2: TestTakingTurnsQueue_FiniteRepetition: The queue couldn't manage limited turns correctly.
// Error 3: TestTakingTurnsQueue_AddPlayerMidway: Couldn't add more people to the game.
// Error 4: TestTakingTurnsQueue_ForeverZero: The person with zero or negative turns wasn't processed correctly.
// Error 5: TestTakingTurnsQueue_Empty: No error was thrown when trying to get someone from an empty queue.

/// <summary>
/// This queue is circular.  When people are added via AddPerson, then they are added to the 
/// back of the queue (per FIFO rules).  When GetNextPerson is called, the next person
/// in the queue is saved to be returned and then they are placed back into the back of the queue.  Thus,
/// each person stays in the queue and is given turns.  When a person is added to the queue, 
/// a turns parameter is provided to identify how many turns they will be given.  If the turns is 0 or
/// less than they will stay in the queue forever.  If a person is out of turns then they will 
/// not be added back into the queue.
/// </summary>
public class TakingTurnsQueue
{
    private readonly PersonQueue _people = new();

    public int Length => _people.Length;

    /// <summary>
    /// Add new people to the queue with a name and number of turns
    /// </summary>
    /// <param name="name">Name of the person</param>
    /// <param name="turns">Number of turns remaining</param>
    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    /// <summary>
    /// Get the next person in the queue and return them. The person should
    /// go to the back of the queue again unless the turns variable shows that they 
    /// have no more turns left.  Note that a turns value of 0 or less means the 
    /// person has an infinite number of turns.  An error exception is thrown 
    /// if the queue is empty.
    /// </summary>
    public Person GetNextPerson()
    {
        if (_people.IsEmpty())
        {
            throw new InvalidOperationException("No one in the queue.");
        }
        else
        {
            Person person = _people.Dequeue();
            if (person.Turns > 0)
            {
                person.Turns -= 1;
            }

            if (person.Turns != 0)
            {
                _people.Enqueue(person);
            }

            return person;
        }
    }

    public override string ToString()
    {
        return _people.ToString();
    }
}
