// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using System.Collections.Generic;

namespace CoachingMentoringInfra.Querying
{
    public class Query
    {
        private IList<Query> _subQueries = new List<Query>();

        public IEnumerable<Query> SubQueries
        {
            get { return _subQueries; }
        }

        public void AddSubQuery(Query subQuery)
        {
            _subQueries.Add(subQuery);
        }

    }
}
