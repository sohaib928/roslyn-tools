namespace CreateTagsForVSRelease
{
    internal sealed class RoslynBuildInformation
    {
        public readonly string CommitSha;
        public readonly string SourceBranch;
        public readonly string BuildId;

        public RoslynBuildInformation(string commitSha, string sourceBranch, string buildId)
        {
            CommitSha = commitSha;
            SourceBranch = sourceBranch;
            BuildId = buildId;
        }
    }
}
