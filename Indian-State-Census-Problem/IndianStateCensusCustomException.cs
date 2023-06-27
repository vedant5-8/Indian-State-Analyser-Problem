
namespace Indian_State_Census_Problem
{
    public class IndianStateCensusCustomException : Exception
    {
        public enum StateCensusExceptionType
        {
            INCORRECT_FILE
        }

        public StateCensusExceptionType type;

        public IndianStateCensusCustomException(StateCensusExceptionType type, string message): base(message)
        {
            this.type = type;
        }

    }
}
