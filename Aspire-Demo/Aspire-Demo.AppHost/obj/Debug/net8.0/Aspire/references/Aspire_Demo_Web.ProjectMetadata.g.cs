namespace Projects;

[global::System.Diagnostics.DebuggerDisplay("Type = {GetType().Name,nq}, ProjectPath = {ProjectPath}")]
public class Aspire_Demo_Web : global::Aspire.Hosting.IProjectMetadata
{
  public string ProjectPath => """C:\dev\aspire\Aspire-Demo\Aspire-Demo.Web\Aspire-Demo.Web.csproj""";
}
