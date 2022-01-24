// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    public abstract class Subject
    {
        private ArrayList observers = new ArrayList();

        public void Attach(IObserver o)
        {
            observers.Add(o);
        }

        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }
    }
    public class ConcreteSubject : Subject
    {
        private string state;

        public string GetState()
        {
            return state;
        }

        public void SetState(string newState)
        {
            state = newState;
            Notify();
        }
    }

    public interface IObserver
    {
        void Update();
    }

    public class ConcreteObserver : IObserver
    {
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject sub)
        {
            subject = sub;
        }

        public void Update()
        {
            string subjectState = subject.GetState();
            Console.WriteLine(subjectState);
        }
    }public class program {
        static void Main(String[] args) {
            ConcreteSubject subject = new ConcreteSubject();
            IObserver observer = new ConcreteObserver(subject);
            IObserver observer1 = new ConcreteObserver(subject);
            IObserver observer2 = new ConcreteObserver(subject);
            subject.Attach(observer);
            subject.Attach(observer2);
            subject.Attach(observer1);
            subject.SetState("My state changed");
        }
    }
    

}

