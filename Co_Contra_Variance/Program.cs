using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co_Contra_Variance
{
    public class Car
    {
        public void Drive()
        {
            Console.WriteLine("bezan berim");
        }
    }

    public class Pride : Car
    {
        public void DoTasadof()
        {
            Console.WriteLine("ba kamale meyl :) ");
        }
    }


    public class Samand : Car
    {

    }

    delegate Car ReturnCarDel();
    delegate Pride ReturnPrideDel();

    delegate void TakeCarDel(Car car);
    delegate void TakePrideDel(Pride pride);

    class Program
    {
        public static Car GetCar()
        {
            return new Car();
        }


        public static Pride GetPride()
        {
            return new Pride();
        }


        public static void Drive(Car car)
        {
            car.Drive();
        }
        public static void DoTasadof(Pride pride)
        {
            pride.DoTasadof();
        }

        public interface IProcess<out T>
        {
            T Process();
        }

        public class CarProcessor<T> : IProcess<T>
        {
            public T Process()
            {
                throw new NotImplementedException();
            }
        }

        public interface IParking<in T>
        {
            void Add(T t);
        }

        public class Parking<T> : IParking<T>
        {
            public void Add(T t)
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            #region Deledate

            #region Co
            //ReturnCarDel d = GetPride;
            //Car a = new Pride();
            //a = d();

            //ReturnPrideDel d2 = GetCar;
            //d2().DoTasadof();
            //Pride v = new Car();
            #endregion

            #region Contra
            //TakePrideDel d11 = Drive;
            //d11(new Pride());

            //TakeCarDel d22 = DoTasadof;
            //d22(new Car());

            #endregion

            #endregion


            #region Array

            //Car[] cars = new Pride[10];
            //cars[0] = new Samand();

            #endregion


            #region Generic

            #region Co
            //IProcess<Car> carProcessesor = new CarProcessor<Car>();
            //IProcess<Pride> prideProcessesor = new CarProcessor<Pride>();

            //Car car = prideProcessesor.Process();
            //carProcessesor = prideProcessesor;

            //IEnumerable<Car> cars = new List<Pride>();
            #endregion

            #region Cont
            //IParking<Car> carParking = new Parking<Car>();
            //carParking.Add(new Car());

            //IParking<Pride> prideParking = new Parking<Pride>();
            //prideParking.Add(new Pride());

            //prideParking = carParking;

            ////  IComparer<
            ////Action<

            #endregion



            #endregion

        }
    }
}
