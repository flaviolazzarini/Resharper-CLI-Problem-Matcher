using Newtonsoft.Json;

public class Xml
{
    [JsonProperty("@version")]
    public string Version { get; set; }
    [JsonProperty("@encoding")]
    public string Encoding { get; set; }
}

public class InspectionScope
{
    public string Element { get; set; }
}

public class Information
{
    public string Solution { get; set; }
    public InspectionScope InspectionScope { get; set; }
}

public class IssueType
{
    [JsonProperty("@Id")]
    public string Id { get; set; }
    [JsonProperty("@Category")]
    public string Category { get; set; }
    [JsonProperty("@CategoryId")]
    public string CategoryId { get; set; }
    [JsonProperty("@Description")]
    public string Description { get; set; }
    [JsonProperty("@Severity")]
    public string Severity { get; set; }
    [JsonProperty("@WikiUrl")]
    public string WikiUrl { get; set; }
    [JsonProperty("@SubCategory")]
    public string SubCategory { get; set; }
    [JsonProperty("@Global")]
    public string Global { get; set; }
}

public class IssueTypes
{
    public List<IssueType> IssueType { get; set; }
}

public class Issue
{
    [JsonProperty("@TypeId")]
    public string TypeId { get; set; }
    [JsonProperty("@File")]
    public string File { get; set; }
    [JsonProperty("@Offset")]
    public string Offset { get; set; }
    [JsonProperty("@Line")]
    public string Line { get; set; }
    [JsonProperty("@Message")]
    public string Message { get; set; }
}

public class Project
{
    [JsonProperty("@Name")]
    public string Name { get; set; }
    public List<Issue> Issue { get; set; }
}

public class Issues
{
    public List<Project> Project { get; set; }
}

public class Report
{
    [JsonProperty("@ToolsVersion")]
    public string ToolsVersion { get; set; }
    public Information Information { get; set; }
    public IssueTypes IssueTypes { get; set; }
    public Issues Issues { get; set; }
}

public class Root
{
    [JsonProperty("?xml")]
    public Xml Xml { get; set; }
    public Report Report { get; set; }
}