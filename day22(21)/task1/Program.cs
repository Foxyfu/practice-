namespace task1
{
    using System;

    // Контекст
    public class Context
    {
        private IState state;

        public Context()
        {
            // Инициализация начального состояния
            state = new State1();
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public void Request()
        {
            state.Handle(this);
        }
    }

    // Абстрактное состояние
    public interface IState
    {
        void Handle(Context context);
    }

    // Конкретные состояния
    public class State1 : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Состояние 1");
            // Логика для состояния 1

            // Переход к следующему состоянию
            context.SetState(new State2());
        }
    }

    public class State2 : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Состояние 2");
            // Логика для состояния 2

            // Переход к следующему состоянию
            context.SetState(new State3());
        }
    }

    public class State3 : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Состояние 3");
            // Логика для состояния 3

            // Переход к следующему состоянию
            context.SetState(new State1()); // Здесь можно изменить логику перехода на следующее состояние, если необходимо
        }
    }

    // Пример использования
    public class Program
    {
        public static void Main(string[] args)
        {
            // Вычисление варианта
            Console.WriteLine("Введите порядковый номер");
            int NP =int.Parse(Console.ReadLine()) ;
            int variant = (NP % 3) + 1;

            // Создание контекста
            Context context = new Context();

            // Установка начального состояния в соответствии с вариантом
            switch (variant)
            {
                case 1:
                    context.SetState(new State1());
                    break;
                case 2:
                    context.SetState(new State2());
                    break;
                case 3:
                    context.SetState(new State3());
                    break;
            }

            // Выполнение запросов
            context.Request();
        }
    }


}