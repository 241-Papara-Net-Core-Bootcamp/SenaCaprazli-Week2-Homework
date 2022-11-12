using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek1.Models
{
    public abstract class Duck
    {
        public abstract void Swim();
        public abstract void Fly();

    }

    public class MallerDuck : Duck
    {
        public override void Fly()
        {
            // yaban ördeği uçabilir
        }

        public override void Swim()
        {
            // yaban ördeği yüzebilir
        }

        public class RubberDuck : Duck
        {
            public override void Fly()
            {
                // plastik örnek uçamaz
                throw new NotImplementedException();
            }

            public override void Swim()
            {
                //Plastik ördek yüzebilir

            }

        }

        public abstract class BaseDuck
        {
            public abstract void Swim();

        }

        public interface IFlyable
        {
            void Fly();

        }

        public class GreenHeadMallerDuck : BaseDuck, IFlyable
        {
            public void Fly()
            {
                  // Yeşil başlı ördek uçabilir
            }

            public override void Swim()
            {
                // Yeşil başlı ördek yüzebilir

            }
        }

        public class YellowRubberDuck : BaseDuck
        {
            public override void Swim()
            {
                // sarı plastik ördek yüzebilir
            }
        }

        public interface IDuck
        {
            void Swim();
           /// void Fly();
        }

        public class BlackHeadDuck : IDuck
        {
            public void Fly()
            {
                throw new NotImplementedException();
            }

            public void Swim()
            {
                // siyah başlı ördek yüzebilir
            }
        }

        public interface IDuckFlyable : IDuck
        {
            void Fly();
        }

        public class YellowHeadRubberDuck : IDuck
        {
         
            public void Swim()
            {
                //sarı kafalı ördek yüzebilir
            }
        }

        public class BlackHeadMallerDuck : IDuckFlyable
        {
            public void Fly()
            {
                throw new NotImplementedException();
            }

            public void Swim()
            {
                throw new NotImplementedException();
            }
        }
    }
}
