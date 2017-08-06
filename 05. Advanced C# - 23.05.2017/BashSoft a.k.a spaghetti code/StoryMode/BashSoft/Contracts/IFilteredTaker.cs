namespace BashSoft.Contracts
{
    public interface IFilteredTaker
    {
        void FilterAndTake(string courseName, string givenFilther, int? studentsToTake = null);
    }
}
