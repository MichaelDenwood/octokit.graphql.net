namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// An account on GitHub, with one or more owners, that has repositories, members and teams.
    /// </summary>
    public class Organization : QueryableValue<Organization>
    {
        internal Organization(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// Determine if this repository owner has any items that can be pinned to their profile.
        /// </summary>
        /// <param name="type">Filter to only a particular kind of pinnable item.</param>
        public bool AnyPinnableItems(Arg<PinnableItemType>? type = null) => default;

        /// <summary>
        /// Audit log entries of the organization
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        /// <param name="orderBy">Ordering options for the returned audit log entries.</param>
        /// <param name="query">The query string to filter audit entries</param>
        public OrganizationAuditEntryConnection AuditLog(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null, Arg<AuditLogOrder>? orderBy = null, Arg<string>? query = null) => this.CreateMethodCall(x => x.AuditLog(first, after, last, before, orderBy, query), Octokit.GraphQL.Model.OrganizationAuditEntryConnection.Create);

        /// <summary>
        /// A URL pointing to the organization's public avatar.
        /// </summary>
        /// <param name="size">The size of the resulting square image.</param>
        public string AvatarUrl(Arg<int>? size = null) => default;

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; }

        /// <summary>
        /// Identifies the primary key from the database.
        /// </summary>
        public int? DatabaseId { get; }

        /// <summary>
        /// The organization's public profile description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The organization's public profile description rendered to HTML.
        /// </summary>
        public string DescriptionHTML { get; }

        /// <summary>
        /// The organization's public email.
        /// </summary>
        public string Email { get; }

        public ID Id { get; }

        /// <summary>
        /// The setting value for whether the organization has an IP allow list enabled.
        /// </summary>
        public IpAllowListEnabledSettingValue IpAllowListEnabledSetting { get; }

        /// <summary>
        /// The IP addresses that are allowed to access resources owned by the organization.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        /// <param name="orderBy">Ordering options for IP allow list entries returned.</param>
        public IpAllowListEntryConnection IpAllowListEntries(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null, Arg<IpAllowListEntryOrder>? orderBy = null) => this.CreateMethodCall(x => x.IpAllowListEntries(first, after, last, before, orderBy), Octokit.GraphQL.Model.IpAllowListEntryConnection.Create);

        /// <summary>
        /// Whether the organization has verified its profile email and website.
        /// </summary>
        public bool IsVerified { get; }

        /// <summary>
        /// Showcases a selection of repositories and gists that the profile owner has either curated or that have been selected automatically based on popularity.
        /// </summary>
        public ProfileItemShowcase ItemShowcase => this.CreateProperty(x => x.ItemShowcase, Octokit.GraphQL.Model.ProfileItemShowcase.Create);

        /// <summary>
        /// The organization's public profile location.
        /// </summary>
        public string Location { get; }

        /// <summary>
        /// The organization's login name.
        /// </summary>
        public string Login { get; }

        /// <summary>
        /// Get the status messages members of this entity have set that are either public or visible only to the organization.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        /// <param name="orderBy">Ordering options for user statuses returned from the connection.</param>
        public UserStatusConnection MemberStatuses(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null, Arg<UserStatusOrder>? orderBy = null) => this.CreateMethodCall(x => x.MemberStatuses(first, after, last, before, orderBy), Octokit.GraphQL.Model.UserStatusConnection.Create);

        /// <summary>
        /// A list of users who are members of this organization.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        public OrganizationMemberConnection MembersWithRole(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null) => this.CreateMethodCall(x => x.MembersWithRole(first, after, last, before), Octokit.GraphQL.Model.OrganizationMemberConnection.Create);

        /// <summary>
        /// The organization's public profile name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The HTTP path creating a new team
        /// </summary>
        public string NewTeamResourcePath { get; }

        /// <summary>
        /// The HTTP URL creating a new team
        /// </summary>
        public string NewTeamUrl { get; }

        /// <summary>
        /// The billing email for the organization.
        /// </summary>
        public string OrganizationBillingEmail { get; }

        /// <summary>
        /// A list of packages under the owner.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        /// <param name="names">Find packages by their names.</param>
        /// <param name="orderBy">Ordering of the returned packages.</param>
        /// <param name="packageType">Filter registry package by type.</param>
        /// <param name="repositoryId">Find packages in a repository by ID.</param>
        public PackageConnection Packages(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null, Arg<IEnumerable<string>>? names = null, Arg<PackageOrder>? orderBy = null, Arg<PackageType>? packageType = null, Arg<ID>? repositoryId = null) => this.CreateMethodCall(x => x.Packages(first, after, last, before, names, orderBy, packageType, repositoryId), Octokit.GraphQL.Model.PackageConnection.Create);

        /// <summary>
        /// A list of users who have been invited to join this organization.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        public UserConnection PendingMembers(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null) => this.CreateMethodCall(x => x.PendingMembers(first, after, last, before), Octokit.GraphQL.Model.UserConnection.Create);

        /// <summary>
        /// A list of repositories and gists this profile owner can pin to their profile.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        /// <param name="types">Filter the types of pinnable items that are returned.</param>
        public PinnableItemConnection PinnableItems(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null, Arg<IEnumerable<PinnableItemType>>? types = null) => this.CreateMethodCall(x => x.PinnableItems(first, after, last, before, types), Octokit.GraphQL.Model.PinnableItemConnection.Create);

        /// <summary>
        /// A list of repositories and gists this profile owner has pinned to their profile
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        /// <param name="types">Filter the types of pinned items that are returned.</param>
        public PinnableItemConnection PinnedItems(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null, Arg<IEnumerable<PinnableItemType>>? types = null) => this.CreateMethodCall(x => x.PinnedItems(first, after, last, before, types), Octokit.GraphQL.Model.PinnableItemConnection.Create);

        /// <summary>
        /// Returns how many more items this profile owner can pin to their profile.
        /// </summary>
        public int PinnedItemsRemaining { get; }

        /// <summary>
        /// Find project by number.
        /// </summary>
        /// <param name="number">The project number to find.</param>
        public Project Project(Arg<int> number) => this.CreateMethodCall(x => x.Project(number), Octokit.GraphQL.Model.Project.Create);

        /// <summary>
        /// A list of projects under the owner.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        /// <param name="orderBy">Ordering options for projects returned from the connection</param>
        /// <param name="search">Query to search projects by, currently only searching by name.</param>
        /// <param name="states">A list of states to filter the projects by.</param>
        public ProjectConnection Projects(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null, Arg<ProjectOrder>? orderBy = null, Arg<string>? search = null, Arg<IEnumerable<ProjectState>>? states = null) => this.CreateMethodCall(x => x.Projects(first, after, last, before, orderBy, search, states), Octokit.GraphQL.Model.ProjectConnection.Create);

        /// <summary>
        /// The HTTP path listing organization's projects
        /// </summary>
        public string ProjectsResourcePath { get; }

        /// <summary>
        /// The HTTP URL listing organization's projects
        /// </summary>
        public string ProjectsUrl { get; }

        /// <summary>
        /// A list of repositories that the user owns.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        /// <param name="affiliations">Array of viewer's affiliation options for repositories returned from the connection. For example, OWNER will include only repositories that the current viewer owns.</param>
        /// <param name="isFork">If non-null, filters repositories according to whether they are forks of another repository</param>
        /// <param name="isLocked">If non-null, filters repositories according to whether they have been locked</param>
        /// <param name="orderBy">Ordering options for repositories returned from the connection</param>
        /// <param name="ownerAffiliations">Array of owner's affiliation options for repositories returned from the connection. For example, OWNER will include only repositories that the organization or user being viewed owns.</param>
        /// <param name="privacy">If non-null, filters repositories according to privacy</param>
        public RepositoryConnection Repositories(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null, Arg<IEnumerable<RepositoryAffiliation?>>? affiliations = null, Arg<bool>? isFork = null, Arg<bool>? isLocked = null, Arg<RepositoryOrder>? orderBy = null, Arg<IEnumerable<RepositoryAffiliation?>>? ownerAffiliations = null, Arg<RepositoryPrivacy>? privacy = null) => this.CreateMethodCall(x => x.Repositories(first, after, last, before, affiliations, isFork, isLocked, orderBy, ownerAffiliations, privacy), Octokit.GraphQL.Model.RepositoryConnection.Create);

        /// <summary>
        /// Find Repository.
        /// </summary>
        /// <param name="name">Name of Repository to find.</param>
        public Repository Repository(Arg<string> name) => this.CreateMethodCall(x => x.Repository(name), Octokit.GraphQL.Model.Repository.Create);

        /// <summary>
        /// When true the organization requires all members, billing managers, and outside collaborators to enable two-factor authentication.
        /// </summary>
        public bool? RequiresTwoFactorAuthentication { get; }

        /// <summary>
        /// The HTTP path for this organization.
        /// </summary>
        public string ResourcePath { get; }

        /// <summary>
        /// The Organization's SAML identity providers
        /// </summary>
        public OrganizationIdentityProvider SamlIdentityProvider => this.CreateProperty(x => x.SamlIdentityProvider, Octokit.GraphQL.Model.OrganizationIdentityProvider.Create);

        /// <summary>
        /// The GitHub Sponsors listing for this user.
        /// </summary>
        public SponsorsListing SponsorsListing => this.CreateProperty(x => x.SponsorsListing, Octokit.GraphQL.Model.SponsorsListing.Create);

        /// <summary>
        /// This object's sponsorships as the maintainer.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        /// <param name="includePrivate">Whether or not to include private sponsorships in the result set</param>
        /// <param name="orderBy">Ordering options for sponsorships returned from this connection. If left blank, the sponsorships will be ordered based on relevancy to the viewer.</param>
        public SponsorshipConnection SponsorshipsAsMaintainer(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null, Arg<bool>? includePrivate = null, Arg<SponsorshipOrder>? orderBy = null) => this.CreateMethodCall(x => x.SponsorshipsAsMaintainer(first, after, last, before, includePrivate, orderBy), Octokit.GraphQL.Model.SponsorshipConnection.Create);

        /// <summary>
        /// This object's sponsorships as the sponsor.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        /// <param name="orderBy">Ordering options for sponsorships returned from this connection. If left blank, the sponsorships will be ordered based on relevancy to the viewer.</param>
        public SponsorshipConnection SponsorshipsAsSponsor(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null, Arg<SponsorshipOrder>? orderBy = null) => this.CreateMethodCall(x => x.SponsorshipsAsSponsor(first, after, last, before, orderBy), Octokit.GraphQL.Model.SponsorshipConnection.Create);

        /// <summary>
        /// Find an organization's team by its slug.
        /// </summary>
        /// <param name="slug">The name or slug of the team to find.</param>
        public Team Team(Arg<string> slug) => this.CreateMethodCall(x => x.Team(slug), Octokit.GraphQL.Model.Team.Create);

        /// <summary>
        /// A list of teams in this organization.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        /// <param name="ldapMapped">If true, filters teams that are mapped to an LDAP Group (Enterprise only)</param>
        /// <param name="orderBy">Ordering options for teams returned from the connection</param>
        /// <param name="privacy">If non-null, filters teams according to privacy</param>
        /// <param name="query">If non-null, filters teams with query on team name and team slug</param>
        /// <param name="role">If non-null, filters teams according to whether the viewer is an admin or member on team</param>
        /// <param name="rootTeamsOnly">If true, restrict to only root teams</param>
        /// <param name="userLogins">User logins to filter by</param>
        public TeamConnection Teams(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null, Arg<bool>? ldapMapped = null, Arg<TeamOrder>? orderBy = null, Arg<TeamPrivacy>? privacy = null, Arg<string>? query = null, Arg<TeamRole>? role = null, Arg<bool>? rootTeamsOnly = null, Arg<IEnumerable<string>>? userLogins = null) => this.CreateMethodCall(x => x.Teams(first, after, last, before, ldapMapped, orderBy, privacy, query, role, rootTeamsOnly, userLogins), Octokit.GraphQL.Model.TeamConnection.Create);

        /// <summary>
        /// The HTTP path listing organization's teams
        /// </summary>
        public string TeamsResourcePath { get; }

        /// <summary>
        /// The HTTP URL listing organization's teams
        /// </summary>
        public string TeamsUrl { get; }

        /// <summary>
        /// The organization's Twitter username.
        /// </summary>
        public string TwitterUsername { get; }

        /// <summary>
        /// Identifies the date and time when the object was last updated.
        /// </summary>
        public DateTimeOffset UpdatedAt { get; }

        /// <summary>
        /// The HTTP URL for this organization.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Organization is adminable by the viewer.
        /// </summary>
        public bool ViewerCanAdminister { get; }

        /// <summary>
        /// Can the viewer pin repositories and gists to the profile?
        /// </summary>
        public bool ViewerCanChangePinnedItems { get; }

        /// <summary>
        /// Can the current viewer create new projects on this owner.
        /// </summary>
        public bool ViewerCanCreateProjects { get; }

        /// <summary>
        /// Viewer can create repositories on this organization
        /// </summary>
        public bool ViewerCanCreateRepositories { get; }

        /// <summary>
        /// Viewer can create teams on this organization.
        /// </summary>
        public bool ViewerCanCreateTeams { get; }

        /// <summary>
        /// Viewer is an active member of this organization.
        /// </summary>
        public bool ViewerIsAMember { get; }

        /// <summary>
        /// The organization's public profile URL.
        /// </summary>
        public string WebsiteUrl { get; }

        internal static Organization Create(Expression expression)
        {
            return new Organization(expression);
        }
    }
}