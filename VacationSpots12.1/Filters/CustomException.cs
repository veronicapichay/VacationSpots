using System;



namespace VacationSpots12._1.Filters
{
    public class CustomException : Exception
    {
        public override string Message
        {
            get
            {

                return "This is a customized exception";


            }



        }


    }
}
