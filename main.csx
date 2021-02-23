#!/usr/bin/env dotnet-script
#load "json_types.csx"
#r "nuget: Newtonsoft.Json, 12.0.3"

using System.Xml;
using Newtonsoft.Json;

Console.WriteLine("Hello world!");
XmlDocument doc = new XmlDocument();
doc.Load("temp.xml");
string json = JsonConvert.SerializeObject(doc);

var test = JsonConvert.DeserializeObject<Root>(json);
var issueTypes = test.Report.IssueTypes.IssueType;
foreach (var project in test.Report.Issues.Project)
{
    foreach (var issue in project.Issue)
    {
        var severity = issueTypes.Where(x => x.Id == issue.TypeId).FirstOrDefault().Severity;
        var column = issue.Offset.Split("-")[0];
        string infos = string.Format("file={0}, line={1}, col={2}", issue.File, issue.Line, column);
        Console.WriteLine("::{0} {1}::{2}", severity, infos, issue.Message);
    }
}

Console.WriteLine("finished")
