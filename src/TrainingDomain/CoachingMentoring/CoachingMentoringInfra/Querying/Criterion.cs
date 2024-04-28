using System;
using System.Linq.Expressions;

namespace CoachingMentoringInfra.Querying
{
    public class Criterion
    {
        private string _propertyName;
        private object _value;
        private DbParamType _dbParamType;

        private CriteriaOperator _criteriaOperator;
        
        public Criterion(string propertyName, object value, DbParamType paramType,
                         CriteriaOperator criteriaOperator)
        {
            _propertyName = propertyName;
            _value = value;
            _dbParamType = paramType;
            _criteriaOperator = criteriaOperator;
        }

        public string PropertyName
        {
            get { return _propertyName; }
        }

        public object Value
        {
            get { return _value; }
        }

        public DbParamType ParamType
        {
            get { return _dbParamType; }
        }

        public CriteriaOperator criteriaOperator
        {
            get { return _criteriaOperator; }
        }

        public static Criterion Create<T>(Expression<Func<T, object>> expression, object value, DbParamType paramType, CriteriaOperator criteriaOperator)
        {
            string propertyName = PropertyNameHelper.ResolvePropertyName<T>(expression);
            Criterion myCriterion = new Criterion(propertyName, value, paramType, criteriaOperator);
            return myCriterion;
        }
    }
}
