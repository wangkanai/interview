param(
  [parameter(Mandatory=$false)] [string]$add,
  [Parameter(Mandatory=$false)] [switch]$list,
  [Parameter(Mandatory=$false)] [switch]$remove
)

$startup="./src/Server/Wangkanai.Interview.Portal.csproj"
$project="./src/Infrastructure/Wangkanai.Interview.Portal.Infrastructure.csproj"

if ($add)
{
  dotnet ef migrations add $add --startup-project $startup --project $project
}
if ($list -eq $true)
{
  dotnet ef migrations list --startup-project $startup --project $project --no-connect
}
if ($remove)
{
  dotnet ef migrations remove --startup-project $startup --project $project --force
}