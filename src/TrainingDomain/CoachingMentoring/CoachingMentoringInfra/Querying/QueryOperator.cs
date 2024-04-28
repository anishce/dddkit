namespace CoachingMentoringInfra.Querying
{
    public enum QueryOperator
    {
        And,
        Or
    }

    public enum QueryName
    {
        Dynamic = 0,
        RetrieveOrdersUsingAComplexQuery = 1,
        StoredProcedure = 2
    }
}
