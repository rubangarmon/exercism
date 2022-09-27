using System;
using System.Text;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        department = department?.ToUpper() ?? "OWNER";
        return id.HasValue ?  $"[{id}] - {name} - {department}" : $"{name} - {department}";
    }
}
