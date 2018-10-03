using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SandBox
{
    public class Calculator
    {

        #region Properties

        public enum Operations { NONE, ADD, SUBSTRACT };

        public Operations Operation { get; set; }
        
        public int Result { get; set; }
        public int InputNumber { get; set; }
        #endregion

        #region Public methods

        public void Add()
        {
            Operation = Operations.ADD;

            Equals();          
        }

        public void Substract()
        {
            Operation = Operations.SUBSTRACT;

            if (Result != 0)
                Equals();
            else
                Result = InputNumber;
        }


        public void Equals()
        {
            switch (Operation)
            {
                case Operations.ADD:
                    Result = Result + InputNumber;
                    break;

                case Operations.SUBSTRACT:
                    Result = Result - InputNumber;
                    break;

                case Operations.NONE:
                default:

                    break;
            }            
        }

        public void Clear()
        {
            Operation = Operations.NONE;

            InputNumber = 0;
            Result = 0;
        }

        
        #endregion

        #region Private methods

        #endregion
    }
}