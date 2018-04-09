using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Golf_Reflex
{
    class StateMachine<T> where T : class, IState
    {
        public Dictionary<string, T> states;    //stores the each state with an ID
        public T currentState;
        public string currentStateID;


        //initialises the dictionary and sets the starting state as the passed in state
        public StateMachine(T startState)
        {
            states = new Dictionary<string, T>();
            currentState = startState;
        }

        //Adds a new state to the dictionary
        public virtual void Add(string id, T state)
        {
            states.Add(id, state);
        }

        //Removes state from dictionary
        public virtual bool Remove(string id)
        {
            return states.Remove(id);
        }

        //changes the current state to the ID passed in
        public virtual void Change(string id)
        {
            currentState.Exit();
            T next = states[id];
            next.Enter();
            currentState = next;
            currentStateID = id;
        }
    }
}