namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of AddPullRequestReview
    /// </summary>
    public class AddPullRequestReviewInput
    {
        public ID PullRequestId { get; set; }

        public string CommitOID { get; set; }

        public string Body { get; set; }

        public PullRequestReviewEvent? Event { get; set; }

        public IEnumerable<DraftPullRequestReviewComment> Comments { get; set; }

        public string ClientMutationId { get; set; }
    }
}