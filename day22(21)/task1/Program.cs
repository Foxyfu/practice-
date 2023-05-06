namespace task1
{
    using System;

    // Абстрактный класс состояния
    abstract class State
    {
        public abstract void HandleState();
    }

    // Конкретные классы состояний
    class State1 : State
    {
        public override void HandleState()
        {
            Console.WriteLine("Обработка состояния 1");
        }
    }

    class State2 : State
    {
        public override void HandleState()
        {
            Console.WriteLine("Обработка состояния 2");
        }
    }

    class State3 : State
    {
        public override void HandleState()
        {
            Console.WriteLine("Обработка состояния 3");
        }
    }

    // Контекст
    class Context
    {
        private State currentState;

        public void SetState(State state)
        {
            currentState = state;
        }

        public void PerformAction()
        {
            currentState.HandleState();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляров состояний
            State state1 = new State1();
            State state2 = new State2();
            State state3 = new State3();

            // Получение порядкового номера и вычисление варианта
            int порядковый_номер = 7;
            int вариант = (порядковый_номер % 3) + 1;

            // Создание контекста с соответствующим состоянием
            Context context = new Context();
            if (вариант == 1)
            {
                context.SetState(state1);
            }
            else if (вариант == 2)
            {
                context.SetState(state2);
            }
            else
            {
                context.SetState(state3);
            }

            // Выполнение действия в зависимости от состояния
            context.PerformAction();
        }
    }

}